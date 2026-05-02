using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.castle
{
[System.Serializable]
public  class CastleUpgradeUserTitleReward : CastleUpgradeReward
 {

    public int level ;
     



    public const int TYPE_ID = 21475;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleUpgradeUserTitleReward(Perfect.Marshal.Octets os) : base(os)  {

        level = os.ReadInt(); 
         
    }

    public CastleUpgradeUserTitleReward()
    {
    }

    public CastleUpgradeUserTitleReward(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "level":  level = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CastleUpgradeUserTitleReward");
        ele.WriteStartElement("level"); ele.WriteInt(level); ele.WriteEndElement();
         
    }


}
}
}
