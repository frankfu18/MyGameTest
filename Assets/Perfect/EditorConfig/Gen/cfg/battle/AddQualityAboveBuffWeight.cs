using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class AddQualityAboveBuffWeight : BattleStartBuffContent
 {

    public cfg.item.EItemQuality quality ;
     public float addRatio ;
     



    public const int TYPE_ID = 28954;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public AddQualityAboveBuffWeight(Perfect.Marshal.Octets os) : base(os)  {

        quality = (cfg.item.EItemQuality)(os.ReadInt()); 
         addRatio = os.ReadFloat(); 
         
    }

    public AddQualityAboveBuffWeight()
    {
    }

    public AddQualityAboveBuffWeight(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "quality":  quality = ele.ReadEnum<cfg.item.EItemQuality>(); break; 
             case "addRatio":  addRatio = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "AddQualityAboveBuffWeight");
        ele.WriteStartElement("quality"); ele.WriteEnum(quality); ele.WriteEndElement();
         ele.WriteStartElement("addRatio"); ele.WriteFloat(addRatio); ele.WriteEndElement();
         
    }


}
}
}
