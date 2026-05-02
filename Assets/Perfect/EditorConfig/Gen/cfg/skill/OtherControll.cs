using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class OtherControll : BulletDestroyType
 {




    public const int TYPE_ID = 13765;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public OtherControll(Perfect.Marshal.Octets os) : base(os)  {

    }

    public OtherControll()
    {
    }

    public OtherControll(XmlElement e)
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
        ele.WriteAttributeString("type", "OtherControll");
    }


}
}
}
