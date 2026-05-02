using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.item
{
[System.Serializable]
public  class SummonInfo : ItemInfo
 {

    public cfg.summon.ESummonType summonType ;
     



    public const int TYPE_ID = 60055;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SummonInfo(Perfect.Marshal.Octets os) : base(os)  {

        summonType = (cfg.summon.ESummonType)(os.ReadInt()); 
         
    }

    public SummonInfo()
    {
    }

    public SummonInfo(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "summonType":  summonType = ele.ReadEnum<cfg.summon.ESummonType>(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SummonInfo");
        ele.WriteStartElement("summonType"); ele.WriteEnum(summonType); ele.WriteEndElement();
         
    }


}
}
}
