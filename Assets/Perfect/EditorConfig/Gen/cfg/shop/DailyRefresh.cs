using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class DailyRefresh : ShopRefreshInfo
 {

    public int count ;
     



    public const int TYPE_ID = 52302;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public DailyRefresh(Perfect.Marshal.Octets os) : base(os)  {

        count = os.ReadInt(); 
         
    }

    public DailyRefresh()
    {
    }

    public DailyRefresh(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "count":  count = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "DailyRefresh");
        ele.WriteStartElement("count"); ele.WriteInt(count); ele.WriteEndElement();
         
    }


}
}
}
