using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class ReleaseSkill : BuffTriggerType
 {




    public const int TYPE_ID = 53388;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public ReleaseSkill(Perfect.Marshal.Octets os) : base(os)  {

    }

    public ReleaseSkill()
    {
    }

    public ReleaseSkill(XmlElement e)
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
        ele.WriteAttributeString("type", "ReleaseSkill");
    }


}
}
}
