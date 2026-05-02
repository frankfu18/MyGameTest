using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class ImmediateTrigger : BuffTriggerType
 {




    public const int TYPE_ID = 27531;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public ImmediateTrigger(Perfect.Marshal.Octets os) : base(os)  {

    }

    public ImmediateTrigger()
    {
    }

    public ImmediateTrigger(XmlElement e)
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
        ele.WriteAttributeString("type", "ImmediateTrigger");
    }


}
}
}
