using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.castle
{
[System.Serializable]
public  class CastleUpgradeSysBuffReward : CastleUpgradeReward
 {

    public int sysBuffId ;
     



    public const int TYPE_ID = 33840;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleUpgradeSysBuffReward(Perfect.Marshal.Octets os) : base(os)  {

        sysBuffId = os.ReadInt(); 
         
    }

    public CastleUpgradeSysBuffReward()
    {
    }

    public CastleUpgradeSysBuffReward(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "sysBuffId":  sysBuffId = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CastleUpgradeSysBuffReward");
        ele.WriteStartElement("sysBuffId"); ele.WriteInt(sysBuffId); ele.WriteEndElement();
         
    }


}
}
}
