using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.map
{
[System.Serializable]
public  class mapEvent :   cfg.EditorWriter 
 {

    public cfg.map.EMapGridCfgType gridType ;
     public string resPath  = "";
     public int weight ;
     



    public const int TYPE_ID = 54439;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public mapEvent(Perfect.Marshal.Octets os) {

        gridType = (cfg.map.EMapGridCfgType)(os.ReadInt()); 
         resPath = os.ReadString(); 
         weight = os.ReadInt(); 
         
    }

    public mapEvent()
    {
    }

    public mapEvent(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "gridType":  gridType = ele.ReadEnum<cfg.map.EMapGridCfgType>(); break; 
             case "resPath":  resPath = ele.ReadString2(); break; 
             case "weight":  weight = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "mapEvent");
        ele.WriteStartElement("gridType"); ele.WriteEnum(gridType); ele.WriteEndElement();
         ele.WriteStartElement("resPath"); ele.WriteString2(resPath); ele.WriteEndElement();
         ele.WriteStartElement("weight"); ele.WriteInt(weight); ele.WriteEndElement();
         
    }


}
}
}
