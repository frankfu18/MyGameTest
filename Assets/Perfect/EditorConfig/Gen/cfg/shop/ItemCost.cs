using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class ItemCost : CostType
 {

    public int itemId ;
     public int itemCount ;
     



    public const int TYPE_ID = 6141;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public ItemCost(Perfect.Marshal.Octets os) : base(os)  {

        itemId = os.ReadInt(); 
         itemCount = os.ReadInt(); 
         
    }

    public ItemCost()
    {
    }

    public ItemCost(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "itemId":  itemId = ele.ReadInt(); break; 
             case "itemCount":  itemCount = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "ItemCost");
        ele.WriteStartElement("itemId"); ele.WriteInt(itemId); ele.WriteEndElement();
         ele.WriteStartElement("itemCount"); ele.WriteInt(itemCount); ele.WriteEndElement();
         
    }


}
}
}
