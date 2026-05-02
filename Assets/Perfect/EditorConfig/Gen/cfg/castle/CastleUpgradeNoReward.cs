using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.castle
{
[System.Serializable]
public  class CastleUpgradeNoReward : CastleUpgradeReward
 {




    public const int TYPE_ID = 19252;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleUpgradeNoReward(Perfect.Marshal.Octets os) : base(os)  {

    }

    public CastleUpgradeNoReward()
    {
    }

    public CastleUpgradeNoReward(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CastleUpgradeNoReward");
    }


}
}
}
