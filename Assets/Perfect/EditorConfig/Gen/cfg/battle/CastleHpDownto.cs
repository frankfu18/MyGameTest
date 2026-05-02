using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class CastleHpDownto : SelectBuffType3Trigger
 {

    public float percent ;
     



    public const int TYPE_ID = 55368;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleHpDownto(Perfect.Marshal.Octets os) : base(os)  {

        percent = os.ReadFloat(); 
         
    }

    public CastleHpDownto()
    {
    }

    public CastleHpDownto(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "percent":  percent = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CastleHpDownto");
        ele.WriteStartElement("percent"); ele.WriteFloat(percent); ele.WriteEndElement();
         
    }


}
}
}
