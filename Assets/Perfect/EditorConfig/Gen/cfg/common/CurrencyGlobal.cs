using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.common
{
[System.Serializable]
public  class CurrencyGlobal :   cfg.EditorWriter 
 {

    public int strengthInit ;
     public int strengthMax ;
     public int strengthRecoverSecond ;
     public int exploreMax ;
     public int exploreCost ;
     



    public const int TYPE_ID = 52209;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CurrencyGlobal(Perfect.Marshal.Octets os) {

        strengthInit = os.ReadInt(); 
         strengthMax = os.ReadInt(); 
         strengthRecoverSecond = os.ReadInt(); 
         exploreMax = os.ReadInt(); 
         exploreCost = os.ReadInt(); 
         
    }

    public CurrencyGlobal()
    {
    }

    public CurrencyGlobal(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "strengthInit":  strengthInit = ele.ReadInt(); break; 
             case "strengthMax":  strengthMax = ele.ReadInt(); break; 
             case "strengthRecoverSecond":  strengthRecoverSecond = ele.ReadInt(); break; 
             case "exploreMax":  exploreMax = ele.ReadInt(); break; 
             case "exploreCost":  exploreCost = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CurrencyGlobal");
        ele.WriteStartElement("strengthInit"); ele.WriteInt(strengthInit); ele.WriteEndElement();
         ele.WriteStartElement("strengthMax"); ele.WriteInt(strengthMax); ele.WriteEndElement();
         ele.WriteStartElement("strengthRecoverSecond"); ele.WriteInt(strengthRecoverSecond); ele.WriteEndElement();
         ele.WriteStartElement("exploreMax"); ele.WriteInt(exploreMax); ele.WriteEndElement();
         ele.WriteStartElement("exploreCost"); ele.WriteInt(exploreCost); ele.WriteEndElement();
         
    }


}
}
}
