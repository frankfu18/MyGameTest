using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class RefreshMonster :   cfg.EditorWriter 
 {

    public int id ;
     public int num ;
     public int wayIndex ;
     public float intervalMin ;
     public float intervalMax ;
     



    public const int TYPE_ID = 8693;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public RefreshMonster(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         num = os.ReadInt(); 
         wayIndex = os.ReadInt(); 
         intervalMin = os.ReadFloat(); 
         intervalMax = os.ReadFloat(); 
         
    }

    public RefreshMonster()
    {
    }

    public RefreshMonster(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "num":  num = ele.ReadInt(); break; 
             case "wayIndex":  wayIndex = ele.ReadInt(); break; 
             case "intervalMin":  intervalMin = ele.ReadFloat(); break; 
             case "intervalMax":  intervalMax = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "RefreshMonster");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("num"); ele.WriteInt(num); ele.WriteEndElement();
         ele.WriteStartElement("wayIndex"); ele.WriteInt(wayIndex); ele.WriteEndElement();
         ele.WriteStartElement("intervalMin"); ele.WriteFloat(intervalMin); ele.WriteEndElement();
         ele.WriteStartElement("intervalMax"); ele.WriteFloat(intervalMax); ele.WriteEndElement();
         
    }


}
}
}
