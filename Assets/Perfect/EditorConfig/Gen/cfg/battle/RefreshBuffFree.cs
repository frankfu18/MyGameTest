using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class RefreshBuffFree : BattleStartBuffContent
 {

    public int num ;
     



    public const int TYPE_ID = 54703;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public RefreshBuffFree(Perfect.Marshal.Octets os) : base(os)  {

        num = os.ReadInt(); 
         
    }

    public RefreshBuffFree()
    {
    }

    public RefreshBuffFree(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "num":  num = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "RefreshBuffFree");
        ele.WriteStartElement("num"); ele.WriteInt(num); ele.WriteEndElement();
         
    }


}
}
}
