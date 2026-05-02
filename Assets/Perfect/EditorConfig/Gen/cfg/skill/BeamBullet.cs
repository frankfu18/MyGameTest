using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class BeamBullet : BulletType
 {




    public const int TYPE_ID = 36088;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BeamBullet(Perfect.Marshal.Octets os) : base(os)  {

    }

    public BeamBullet()
    {
    }

    public BeamBullet(XmlElement e)
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
        ele.WriteAttributeString("type", "BeamBullet");
    }


}
}
}
