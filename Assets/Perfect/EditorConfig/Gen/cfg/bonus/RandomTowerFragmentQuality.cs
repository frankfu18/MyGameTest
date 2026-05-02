using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.bonus
{
[System.Serializable]
public  class RandomTowerFragmentQuality : Bonus
 {

    public cfg.item.EItemQuality quality ;
     



    public const int TYPE_ID = 12489;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public RandomTowerFragmentQuality(Perfect.Marshal.Octets os) : base(os)  {

        quality = (cfg.item.EItemQuality)(os.ReadInt()); 
         
    }

    public RandomTowerFragmentQuality()
    {
    }

    public RandomTowerFragmentQuality(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "quality":  quality = ele.ReadEnum<cfg.item.EItemQuality>(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "RandomTowerFragmentQuality");
        ele.WriteStartElement("quality"); ele.WriteEnum(quality); ele.WriteEndElement();
         
    }


}
}
}
