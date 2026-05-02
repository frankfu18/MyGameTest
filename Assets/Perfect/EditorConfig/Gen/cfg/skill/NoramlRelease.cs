using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class NoramlRelease : SkillReleaseType
 {




    public const int TYPE_ID = 38660;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public NoramlRelease(Perfect.Marshal.Octets os) : base(os)  {

    }

    public NoramlRelease()
    {
    }

    public NoramlRelease(XmlElement e)
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
        ele.WriteAttributeString("type", "NoramlRelease");
    }


}
}
}
