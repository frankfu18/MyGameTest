using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class SingleCount : SelectCount
 {




    public const int TYPE_ID = 15319;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SingleCount(Perfect.Marshal.Octets os) : base(os)  {

    }

    public SingleCount()
    {
    }

    public SingleCount(XmlElement e)
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
        ele.WriteAttributeString("type", "SingleCount");
    }


}
}
}
