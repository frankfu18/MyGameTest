using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.tower
{
[System.Serializable]
public  class TowerSlot :   cfg.EditorWriter 
 {

    public int index ;
     public cfg.tower.SlotInfo defaultSlotInfo ;
     



    public const int TYPE_ID = 445;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public TowerSlot(Perfect.Marshal.Octets os) {

        index = os.ReadInt(); 
         defaultSlotInfo = cfg.Extensions.unmarshal_cfg_tower_SlotInfo(os); 
         
    }

    public TowerSlot()
    {
    }

    public TowerSlot(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "index":  index = ele.ReadInt(); break; 
             case "defaultSlotInfo":  defaultSlotInfo = cfg.Extensions.xml_unmarshal_cfg_tower_SlotInfo(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "TowerSlot");
        ele.WriteStartElement("index"); ele.WriteInt(index); ele.WriteEndElement();
         ele.WriteStartElement("defaultSlotInfo"); cfg.Extensions.xml_marshal_cfg_tower_SlotInfo(defaultSlotInfo,ele); ele.WriteEndElement();
         
    }


}
}
}
