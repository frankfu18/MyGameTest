using System.Xml;
namespace editor
{
    namespace cfg
    {
        public static class Extensions
        {
            public static System.Collections.Generic.List<cfg.common.Cost> unmarshal_list_cfg_common_Cost(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.common.Cost>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_common_Cost(os));
                            }return x;
                         }
            public static cfg.common.Currency unmarshal_cfg_common_Currency(Perfect.Marshal.Octets os) {
                            return new cfg.common.Currency(os);
                         }
            public static cfg.common.CurrencyCost unmarshal_cfg_common_CurrencyCost(Perfect.Marshal.Octets os) {
                            return new cfg.common.CurrencyCost(os);
                         }
            public static cfg.common.Or unmarshal_cfg_common_Or(Perfect.Marshal.Octets os) {
                            return new cfg.common.Or(os);
                         }
            public static cfg.common.AdCost unmarshal_cfg_common_AdCost(Perfect.Marshal.Octets os) {
                            return new cfg.common.AdCost(os);
                         }
            public static cfg.Vector2 unmarshal_cfg_Vector2(Perfect.Marshal.Octets os) {
                            return new cfg.Vector2(os);
                         }
            public static cfg.Vector3 unmarshal_cfg_Vector3(Perfect.Marshal.Octets os) {
                            return new cfg.Vector3(os);
                         }
            public static cfg.Vector2Int unmarshal_cfg_Vector2Int(Perfect.Marshal.Octets os) {
                            return new cfg.Vector2Int(os);
                         }
            public static cfg.common.And unmarshal_cfg_common_And(Perfect.Marshal.Octets os) {
                            return new cfg.common.And(os);
                         }
            public static cfg.common.XBigDecimal unmarshal_cfg_common_XBigDecimal(Perfect.Marshal.Octets os) {
                            return new cfg.common.XBigDecimal(os);
                         }
            public static cfg.common.XNumber unmarshal_cfg_common_XNumber(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.common.XNumber x;
                            switch(id) {
                            case 0: return null;
                            case 13651 : x = new cfg.common.XInt(os); break;case 5234 : x = new cfg.common.XLong(os); break;case 24592 : x = new cfg.common.XFloat(os); break;case 52174 : x = new cfg.common.XBigDecimal(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.common.None unmarshal_cfg_common_None(Perfect.Marshal.Octets os) {
                            return new cfg.common.None(os);
                         }
            public static cfg.common.MoneyCost unmarshal_cfg_common_MoneyCost(Perfect.Marshal.Octets os) {
                            return new cfg.common.MoneyCost(os);
                         }
            public static cfg.common.XFloat unmarshal_cfg_common_XFloat(Perfect.Marshal.Octets os) {
                            return new cfg.common.XFloat(os);
                         }
            public static cfg.common.XInt unmarshal_cfg_common_XInt(Perfect.Marshal.Octets os) {
                            return new cfg.common.XInt(os);
                         }
            public static cfg.common.ItemCost unmarshal_cfg_common_ItemCost(Perfect.Marshal.Octets os) {
                            return new cfg.common.ItemCost(os);
                         }
            public static System.Collections.Generic.List<cfg.common.Currency> unmarshal_list_cfg_common_Currency(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.common.Currency>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_common_Currency(os));
                            }return x;
                         }
            public static cfg.common.XLong unmarshal_cfg_common_XLong(Perfect.Marshal.Octets os) {
                            return new cfg.common.XLong(os);
                         }
            public static cfg.common.Cost unmarshal_cfg_common_Cost(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.common.Cost x;
                            switch(id) {
                            case 0: return null;
                            case 12910 : x = new cfg.common.None(os); break;case 37017 : x = new cfg.common.AdCost(os); break;case 21220 : x = new cfg.common.CurrencyCost(os); break;case 46930 : x = new cfg.common.ItemCost(os); break;case 8726 : x = new cfg.common.And(os); break;case 23102 : x = new cfg.common.Or(os); break;case 50266 : x = new cfg.common.MoneyCost(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }


            public static void xml_marshal_list_cfg_common_Cost(System.Collections.Generic.List<cfg.common.Cost> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_common_Cost(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_common_Currency(cfg.common.Currency x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_CurrencyCost(cfg.common.CurrencyCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_Or(cfg.common.Or x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_AdCost(cfg.common.AdCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_Vector2(cfg.Vector2 x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_Vector3(cfg.Vector3 x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_Vector2Int(cfg.Vector2Int x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_And(cfg.common.And x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_XBigDecimal(cfg.common.XBigDecimal x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_XNumber(cfg.common.XNumber x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_None(cfg.common.None x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_MoneyCost(cfg.common.MoneyCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_XFloat(cfg.common.XFloat x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_XInt(cfg.common.XInt x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_ItemCost(cfg.common.ItemCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_common_Currency(System.Collections.Generic.List<cfg.common.Currency> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_common_Currency(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_common_XLong(cfg.common.XLong x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_Cost(cfg.common.Cost x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }

            public static System.Collections.Generic.List<cfg.common.Cost> xml_unmarshal_list_cfg_common_Cost(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.common.Cost>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_common_Cost(c));
                            }return x;
                         }
            public static cfg.common.Currency xml_unmarshal_cfg_common_Currency(XmlElement ele) {
                            var x = new cfg.common.Currency(ele);
                            return x;
                         }
            public static cfg.common.CurrencyCost xml_unmarshal_cfg_common_CurrencyCost(XmlElement ele) {
                            var x = new cfg.common.CurrencyCost(ele);
                            return x;
                         }
            public static cfg.common.Or xml_unmarshal_cfg_common_Or(XmlElement ele) {
                            var x = new cfg.common.Or(ele);
                            return x;
                         }
            public static cfg.common.AdCost xml_unmarshal_cfg_common_AdCost(XmlElement ele) {
                            var x = new cfg.common.AdCost(ele);
                            return x;
                         }
            public static cfg.Vector2 xml_unmarshal_cfg_Vector2(XmlElement ele) {
                            var x = new cfg.Vector2(ele);
                            return x;
                         }
            public static cfg.Vector3 xml_unmarshal_cfg_Vector3(XmlElement ele) {
                            var x = new cfg.Vector3(ele);
                            return x;
                         }
            public static cfg.Vector2Int xml_unmarshal_cfg_Vector2Int(XmlElement ele) {
                            var x = new cfg.Vector2Int(ele);
                            return x;
                         }
            public static cfg.common.And xml_unmarshal_cfg_common_And(XmlElement ele) {
                            var x = new cfg.common.And(ele);
                            return x;
                         }
            public static cfg.common.XBigDecimal xml_unmarshal_cfg_common_XBigDecimal(XmlElement ele) {
                            var x = new cfg.common.XBigDecimal(ele);
                            return x;
                         }
            public static cfg.common.XNumber xml_unmarshal_cfg_common_XNumber(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.common.XNumber x;
                            switch(type) {
                            case "null": return null;
                            case "XInt" : x = new cfg.common.XInt(ele); break;
                            case "XLong" : x = new cfg.common.XLong(ele); break;
                            case "XFloat" : x = new cfg.common.XFloat(ele); break;
                            case "XBigDecimal" : x = new cfg.common.XBigDecimal(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.common.None xml_unmarshal_cfg_common_None(XmlElement ele) {
                            var x = new cfg.common.None(ele);
                            return x;
                         }
            public static cfg.common.MoneyCost xml_unmarshal_cfg_common_MoneyCost(XmlElement ele) {
                            var x = new cfg.common.MoneyCost(ele);
                            return x;
                         }
            public static cfg.common.XFloat xml_unmarshal_cfg_common_XFloat(XmlElement ele) {
                            var x = new cfg.common.XFloat(ele);
                            return x;
                         }
            public static cfg.common.XInt xml_unmarshal_cfg_common_XInt(XmlElement ele) {
                            var x = new cfg.common.XInt(ele);
                            return x;
                         }
            public static cfg.common.ItemCost xml_unmarshal_cfg_common_ItemCost(XmlElement ele) {
                            var x = new cfg.common.ItemCost(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.common.Currency> xml_unmarshal_list_cfg_common_Currency(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.common.Currency>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_common_Currency(c));
                            }return x;
                         }
            public static cfg.common.XLong xml_unmarshal_cfg_common_XLong(XmlElement ele) {
                            var x = new cfg.common.XLong(ele);
                            return x;
                         }
            public static cfg.common.Cost xml_unmarshal_cfg_common_Cost(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.common.Cost x;
                            switch(type) {
                            case "null": return null;
                            case "None" : x = new cfg.common.None(ele); break;
                            case "AdCost" : x = new cfg.common.AdCost(ele); break;
                            case "CurrencyCost" : x = new cfg.common.CurrencyCost(ele); break;
                            case "ItemCost" : x = new cfg.common.ItemCost(ele); break;
                            case "And" : x = new cfg.common.And(ele); break;
                            case "Or" : x = new cfg.common.Or(ele); break;
                            case "MoneyCost" : x = new cfg.common.MoneyCost(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }

        }
    }
}
