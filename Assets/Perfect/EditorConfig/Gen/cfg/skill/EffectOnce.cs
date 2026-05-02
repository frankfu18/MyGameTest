using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class EffectOnce : BulletDestroyType
 {




    public const int TYPE_ID = 63888;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public EffectOnce(Perfect.Marshal.Octets os) : base(os)  {

    }

    public EffectOnce()
    {
    }

    public EffectOnce(XmlElement e)
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
        ele.WriteAttributeString("type", "EffectOnce");
    }


}
}
}
