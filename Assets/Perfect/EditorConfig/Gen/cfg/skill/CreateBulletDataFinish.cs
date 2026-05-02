using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class CreateBulletDataFinish : BuffTriggerType
 {




    public const int TYPE_ID = 63727;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CreateBulletDataFinish(Perfect.Marshal.Octets os) : base(os)  {

    }

    public CreateBulletDataFinish()
    {
    }

    public CreateBulletDataFinish(XmlElement e)
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
        ele.WriteAttributeString("type", "CreateBulletDataFinish");
    }


}
}
}
