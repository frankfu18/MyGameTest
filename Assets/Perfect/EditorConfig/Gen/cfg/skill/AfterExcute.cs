using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class AfterExcute : BuffDestroyType
 {




    public const int TYPE_ID = 43169;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public AfterExcute(Perfect.Marshal.Octets os) : base(os)  {

    }

    public AfterExcute()
    {
    }

    public AfterExcute(XmlElement e)
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
        ele.WriteAttributeString("type", "AfterExcute");
    }


}
}
}
