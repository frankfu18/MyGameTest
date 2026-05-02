using System.Xml;
namespace editor
{
    namespace cfg
    {
        public static class Extensions
        {
            public static cfg.battle.RandomBuff unmarshal_cfg_battle_RandomBuff(Perfect.Marshal.Octets os) {
                            return new cfg.battle.RandomBuff(os);
                         }
            public static cfg.skill.Fire unmarshal_cfg_skill_Fire(Perfect.Marshal.Octets os) {
                            return new cfg.skill.Fire(os);
                         }
            public static cfg.global.GInt64 unmarshal_cfg_global_GInt64(Perfect.Marshal.Octets os) {
                            return new cfg.global.GInt64(os);
                         }
            public static cfg.user.UserTitle unmarshal_cfg_user_UserTitle(Perfect.Marshal.Octets os) {
                            return new cfg.user.UserTitle(os);
                         }
            public static cfg.item.ItemInfo unmarshal_cfg_item_ItemInfo(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.item.ItemInfo x;
                            switch(id) {
                            case 0: return null;
                            case 7166 : x = new cfg.item.None(os); break;case 41267 : x = new cfg.item.TowerFragmentInfo(os); break;case 46305 : x = new cfg.item.GiftInfo(os); break;case 5055 : x = new cfg.item.CastleSkillFragmentInfo(os); break;case 60055 : x = new cfg.item.SummonInfo(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.skill.Frozen unmarshal_cfg_skill_Frozen(Perfect.Marshal.Octets os) {
                            return new cfg.skill.Frozen(os);
                         }
            public static cfg.function.Jump unmarshal_cfg_function_Jump(Perfect.Marshal.Octets os) {
                            return new cfg.function.Jump(os);
                         }
            public static cfg.item.None unmarshal_cfg_item_None(Perfect.Marshal.Octets os) {
                            return new cfg.item.None(os);
                         }
            public static cfg.localize.TexSizeElement unmarshal_cfg_localize_TexSizeElement(Perfect.Marshal.Octets os) {
                            return new cfg.localize.TexSizeElement(os);
                         }
            public static cfg.shop.SellCurrency unmarshal_cfg_shop_SellCurrency(Perfect.Marshal.Octets os) {
                            return new cfg.shop.SellCurrency(os);
                         }
            public static cfg.map.MapOutDirFilter unmarshal_cfg_map_MapOutDirFilter(Perfect.Marshal.Octets os) {
                            return new cfg.map.MapOutDirFilter(os);
                         }
            public static cfg.summon.Summon unmarshal_cfg_summon_Summon(Perfect.Marshal.Octets os) {
                            return new cfg.summon.Summon(os);
                         }
            public static cfg.castle.CastleSkill unmarshal_cfg_castle_CastleSkill(Perfect.Marshal.Octets os) {
                            return new cfg.castle.CastleSkill(os);
                         }
            public static cfg.skill.Delay unmarshal_cfg_skill_Delay(Perfect.Marshal.Octets os) {
                            return new cfg.skill.Delay(os);
                         }
            public static cfg.skill.HitAnyOne unmarshal_cfg_skill_HitAnyOne(Perfect.Marshal.Octets os) {
                            return new cfg.skill.HitAnyOne(os);
                         }
            public static cfg.error.Error unmarshal_cfg_error_Error(Perfect.Marshal.Octets os) {
                            return new cfg.error.Error(os);
                         }
            public static cfg.battle.BattleStartBuffContent unmarshal_cfg_battle_BattleStartBuffContent(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.battle.BattleStartBuffContent x;
                            switch(id) {
                            case 0: return null;
                            case 59428 : x = new cfg.battle.StartSelectBuffOnce(os); break;case 54703 : x = new cfg.battle.RefreshBuffFree(os); break;case 35767 : x = new cfg.battle.BattleIncomeAdd(os); break;case 28954 : x = new cfg.battle.AddQualityAboveBuffWeight(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.skill.ImmediateBullet unmarshal_cfg_skill_ImmediateBullet(Perfect.Marshal.Octets os) {
                            return new cfg.skill.ImmediateBullet(os);
                         }
            public static cfg.sysbuff.BattleStartBuff unmarshal_cfg_sysbuff_BattleStartBuff(Perfect.Marshal.Octets os) {
                            return new cfg.sysbuff.BattleStartBuff(os);
                         }
            public static cfg.battle.KillExpAdd unmarshal_cfg_battle_KillExpAdd(Perfect.Marshal.Octets os) {
                            return new cfg.battle.KillExpAdd(os);
                         }
            public static cfg.battle.RefreshMonster unmarshal_cfg_battle_RefreshMonster(Perfect.Marshal.Octets os) {
                            return new cfg.battle.RefreshMonster(os);
                         }
            public static cfg.shop.ShopInfo unmarshal_cfg_shop_ShopInfo(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.shop.ShopInfo x;
                            switch(id) {
                            case 0: return null;
                            case 14417 : x = new cfg.shop.NromalShopInfo(os); break;case 44330 : x = new cfg.shop.DailyShopInfo(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.skill.BuffConfig unmarshal_cfg_skill_BuffConfig(Perfect.Marshal.Octets os) {
                            return new cfg.skill.BuffConfig(os);
                         }
            public static cfg.shop.ItemCost unmarshal_cfg_shop_ItemCost(Perfect.Marshal.Octets os) {
                            return new cfg.shop.ItemCost(os);
                         }
            public static cfg.skill.BulletConfig unmarshal_cfg_skill_BulletConfig(Perfect.Marshal.Octets os) {
                            return new cfg.skill.BulletConfig(os);
                         }
            public static cfg.skill.BuffChangeContent unmarshal_cfg_skill_BuffChangeContent(Perfect.Marshal.Octets os) {
                            return new cfg.skill.BuffChangeContent(os);
                         }
            public static cfg.castle.CastleUpgradeUserTitleReward unmarshal_cfg_castle_CastleUpgradeUserTitleReward(Perfect.Marshal.Octets os) {
                            return new cfg.castle.CastleUpgradeUserTitleReward(os);
                         }
            public static System.Collections.Generic.List<cfg.summon.SummonUpgrade> unmarshal_list_cfg_summon_SummonUpgrade(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.summon.SummonUpgrade>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_summon_SummonUpgrade(os));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.level.Chapter> unmarshal_list_cfg_level_Chapter(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.level.Chapter>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_level_Chapter(os));
                            }return x;
                         }
            public static cfg.skill.BuffDestroyType unmarshal_cfg_skill_BuffDestroyType(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.skill.BuffDestroyType x;
                            switch(id) {
                            case 0: return null;
                            case 16224 : x = new cfg.skill.Forever(os); break;case 43169 : x = new cfg.skill.AfterExcute(os); break;case 30151 : x = new cfg.skill.InFixTime(os); break;case 12635 : x = new cfg.skill.StateDisappear(os); break;case 24144 : x = new cfg.skill.BuffRemove(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.skill.AddBuff unmarshal_cfg_skill_AddBuff(Perfect.Marshal.Octets os) {
                            return new cfg.skill.AddBuff(os);
                         }
            public static cfg.battle.RandomBuffLibContent unmarshal_cfg_battle_RandomBuffLibContent(Perfect.Marshal.Octets os) {
                            return new cfg.battle.RandomBuffLibContent(os);
                         }
            public static cfg.skill.HitImmediate unmarshal_cfg_skill_HitImmediate(Perfect.Marshal.Octets os) {
                            return new cfg.skill.HitImmediate(os);
                         }
            public static cfg.shop.DailyGoods unmarshal_cfg_shop_DailyGoods(Perfect.Marshal.Octets os) {
                            return new cfg.shop.DailyGoods(os);
                         }
            public static cfg.battle.StartSelectBuffOnce unmarshal_cfg_battle_StartSelectBuffOnce(Perfect.Marshal.Octets os) {
                            return new cfg.battle.StartSelectBuffOnce(os);
                         }
            public static cfg.battle.SingeTowerTarget unmarshal_cfg_battle_SingeTowerTarget(Perfect.Marshal.Octets os) {
                            return new cfg.battle.SingeTowerTarget(os);
                         }
            public static cfg.castle.CastleUpgradeSysBuffReward unmarshal_cfg_castle_CastleUpgradeSysBuffReward(Perfect.Marshal.Octets os) {
                            return new cfg.castle.CastleUpgradeSysBuffReward(os);
                         }
            public static cfg.shop.GoodsInfo unmarshal_cfg_shop_GoodsInfo(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.shop.GoodsInfo x;
                            switch(id) {
                            case 0: return null;
                            case 55656 : x = new cfg.shop.NormalGoods(os); break;case 29286 : x = new cfg.shop.EveryDayFreeGoods(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.battle.SelectBuffType unmarshal_cfg_battle_SelectBuffType(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.battle.SelectBuffType x;
                            switch(id) {
                            case 0: return null;
                            case 62026 : x = new cfg.battle.SelectBuffType1(os); break;case 62027 : x = new cfg.battle.SelectBuffType2(os); break;case 62028 : x = new cfg.battle.SelectBuffType3(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.localize.TexLocalizeElements unmarshal_cfg_localize_TexLocalizeElements(Perfect.Marshal.Octets os) {
                            return new cfg.localize.TexLocalizeElements(os);
                         }
            public static cfg.skill.EffectNum unmarshal_cfg_skill_EffectNum(Perfect.Marshal.Octets os) {
                            return new cfg.skill.EffectNum(os);
                         }
            public static cfg.skill.HpChange unmarshal_cfg_skill_HpChange(Perfect.Marshal.Octets os) {
                            return new cfg.skill.HpChange(os);
                         }
            public static cfg.tower.TowerUpgradeWithBuffInfo unmarshal_cfg_tower_TowerUpgradeWithBuffInfo(Perfect.Marshal.Octets os) {
                            return new cfg.tower.TowerUpgradeWithBuffInfo(os);
                         }
            public static System.Collections.Generic.List<cfg.map.MapOutDirFilter> unmarshal_list_cfg_map_MapOutDirFilter(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.map.MapOutDirFilter>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_map_MapOutDirFilter(os));
                            }return x;
                         }
            public static cfg.skill.ReleaseBuff unmarshal_cfg_skill_ReleaseBuff(Perfect.Marshal.Octets os) {
                            return new cfg.skill.ReleaseBuff(os);
                         }
            public static cfg.condition.None unmarshal_cfg_condition_None(Perfect.Marshal.Octets os) {
                            return new cfg.condition.None(os);
                         }
            public static cfg.sound.Audio unmarshal_cfg_sound_Audio(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.sound.Audio x;
                            switch(id) {
                            case 0: return null;
                            case 11565 : x = new cfg.sound.SoundEffect(os); break;case 58755 : x = new cfg.sound.Music(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.item.CastleSkillFragmentInfo unmarshal_cfg_item_CastleSkillFragmentInfo(Perfect.Marshal.Octets os) {
                            return new cfg.item.CastleSkillFragmentInfo(os);
                         }
            public static cfg.skill.BeforeDeadHaveState unmarshal_cfg_skill_BeforeDeadHaveState(Perfect.Marshal.Octets os) {
                            return new cfg.skill.BeforeDeadHaveState(os);
                         }
            public static System.Collections.Generic.List<cfg.localize.Language> unmarshal_list_cfg_localize_Language(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.localize.Language>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_localize_Language(os));
                            }return x;
                         }
            public static cfg.skill.HitFixTarget unmarshal_cfg_skill_HitFixTarget(Perfect.Marshal.Octets os) {
                            return new cfg.skill.HitFixTarget(os);
                         }
            public static cfg.battle.GlobalTarget unmarshal_cfg_battle_GlobalTarget(Perfect.Marshal.Octets os) {
                            return new cfg.battle.GlobalTarget(os);
                         }
            public static cfg.skill.TerrainBullet unmarshal_cfg_skill_TerrainBullet(Perfect.Marshal.Octets os) {
                            return new cfg.skill.TerrainBullet(os);
                         }
            public static cfg.shop.CostWithInterval unmarshal_cfg_shop_CostWithInterval(Perfect.Marshal.Octets os) {
                            return new cfg.shop.CostWithInterval(os);
                         }
            public static cfg.map.MapGround unmarshal_cfg_map_MapGround(Perfect.Marshal.Octets os) {
                            return new cfg.map.MapGround(os);
                         }
            public static cfg.skill.HitDelay unmarshal_cfg_skill_HitDelay(Perfect.Marshal.Octets os) {
                            return new cfg.skill.HitDelay(os);
                         }
            public static cfg.function.JumpBattleInfo unmarshal_cfg_function_JumpBattleInfo(Perfect.Marshal.Octets os) {
                            return new cfg.function.JumpBattleInfo(os);
                         }
            public static cfg.battle.CastleHpDownto unmarshal_cfg_battle_CastleHpDownto(Perfect.Marshal.Octets os) {
                            return new cfg.battle.CastleHpDownto(os);
                         }
            public static cfg.bonus.CopyBonus unmarshal_cfg_bonus_CopyBonus(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.CopyBonus(os);
                         }
            public static cfg.tower.TowerSlot unmarshal_cfg_tower_TowerSlot(Perfect.Marshal.Octets os) {
                            return new cfg.tower.TowerSlot(os);
                         }
            public static cfg.shop.DailyRefresh unmarshal_cfg_shop_DailyRefresh(Perfect.Marshal.Octets os) {
                            return new cfg.shop.DailyRefresh(os);
                         }
            public static cfg.battle.SelectBuffType3 unmarshal_cfg_battle_SelectBuffType3(Perfect.Marshal.Octets os) {
                            return new cfg.battle.SelectBuffType3(os);
                         }
            public static cfg.common.XBigDecimal unmarshal_cfg_common_XBigDecimal(Perfect.Marshal.Octets os) {
                            return new cfg.common.XBigDecimal(os);
                         }
            public static cfg.battle.SelectBuffType2 unmarshal_cfg_battle_SelectBuffType2(Perfect.Marshal.Octets os) {
                            return new cfg.battle.SelectBuffType2(os);
                         }
            public static cfg.battle.SelectBuffType1 unmarshal_cfg_battle_SelectBuffType1(Perfect.Marshal.Octets os) {
                            return new cfg.battle.SelectBuffType1(os);
                         }
            public static cfg.skill.BuffRemove unmarshal_cfg_skill_BuffRemove(Perfect.Marshal.Octets os) {
                            return new cfg.skill.BuffRemove(os);
                         }
            public static cfg.shop.ShopRefreshInfo unmarshal_cfg_shop_ShopRefreshInfo(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.shop.ShopRefreshInfo x;
                            switch(id) {
                            case 0: return null;
                            case 53704 : x = new cfg.shop.NotRefresh(os); break;case 52302 : x = new cfg.shop.DailyRefresh(os); break;case 49412 : x = new cfg.shop.WeeklyRefresh(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.sound.Sound> unmarshal_list_cfg_sound_Sound(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.sound.Sound>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_sound_Sound(os));
                            }return x;
                         }
            public static cfg.skill.BulletTrackConfig unmarshal_cfg_skill_BulletTrackConfig(Perfect.Marshal.Octets os) {
                            return new cfg.skill.BulletTrackConfig(os);
                         }
            public static cfg.map.OutDirFilterAdd unmarshal_cfg_map_OutDirFilterAdd(Perfect.Marshal.Octets os) {
                            return new cfg.map.OutDirFilterAdd(os);
                         }
            public static System.Collections.Generic.List<cfg.summon.SummonReward> unmarshal_list_cfg_summon_SummonReward(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.summon.SummonReward>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_summon_SummonReward(os));
                            }return x;
                         }
            public static cfg.tower.TowerUpgradeInfo unmarshal_cfg_tower_TowerUpgradeInfo(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.tower.TowerUpgradeInfo x;
                            switch(id) {
                            case 0: return null;
                            case 15725 : x = new cfg.tower.TowerUpgradeNoBuffInfo(os); break;case 44057 : x = new cfg.tower.TowerUpgradeWithBuffInfo(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.map.mapEventShowWeight> unmarshal_list_cfg_map_mapEventShowWeight(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.map.mapEventShowWeight>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_map_mapEventShowWeight(os));
                            }return x;
                         }
            public static cfg.battle.MapBuild unmarshal_cfg_battle_MapBuild(Perfect.Marshal.Octets os) {
                            return new cfg.battle.MapBuild(os);
                         }
            public static System.Collections.Generic.List<cfg.asset.Asset> unmarshal_list_cfg_asset_Asset(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.asset.Asset>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_asset_Asset(os));
                            }return x;
                         }
            public static cfg.localize.TexPositionElement unmarshal_cfg_localize_TexPositionElement(Perfect.Marshal.Octets os) {
                            return new cfg.localize.TexPositionElement(os);
                         }
            public static cfg.bonus.Item unmarshal_cfg_bonus_Item(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.Item(os);
                         }
            public static System.Collections.Generic.List<cfg.level.BattleLevel> unmarshal_list_cfg_level_BattleLevel(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.level.BattleLevel>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_level_BattleLevel(os));
                            }return x;
                         }
            public static cfg.battle.MoneyWaveAdd unmarshal_cfg_battle_MoneyWaveAdd(Perfect.Marshal.Octets os) {
                            return new cfg.battle.MoneyWaveAdd(os);
                         }
            public static cfg.skill.EffectUnlimit unmarshal_cfg_skill_EffectUnlimit(Perfect.Marshal.Octets os) {
                            return new cfg.skill.EffectUnlimit(os);
                         }
            public static System.Collections.Generic.Dictionary<int,cfg.tower.TowerUpgradeInfo> unmarshal_map_int_cfg_tower_TowerUpgradeInfo(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.Dictionary<int,cfg.tower.TowerUpgradeInfo>(n * 7 / 5);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(os.ReadInt(), cfg.Extensions.unmarshal_cfg_tower_TowerUpgradeInfo(os));
                            }return x;
                         }
            public static cfg.castle.CastleUpgradeReward unmarshal_cfg_castle_CastleUpgradeReward(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.castle.CastleUpgradeReward x;
                            switch(id) {
                            case 0: return null;
                            case 19252 : x = new cfg.castle.CastleUpgradeNoReward(os); break;case 42259 : x = new cfg.castle.CastleUpgradeBonusReward(os); break;case 33840 : x = new cfg.castle.CastleUpgradeSysBuffReward(os); break;case 21475 : x = new cfg.castle.CastleUpgradeUserTitleReward(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.map.mapEventShowWeight unmarshal_cfg_map_mapEventShowWeight(Perfect.Marshal.Octets os) {
                            return new cfg.map.mapEventShowWeight(os);
                         }
            public static System.Collections.Generic.List<cfg.attribute.Attribute> unmarshal_list_cfg_attribute_Attribute(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.attribute.Attribute>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_attribute_Attribute(os));
                            }return x;
                         }
            public static cfg.item.Item unmarshal_cfg_item_Item(Perfect.Marshal.Octets os) {
                            return new cfg.item.Item(os);
                         }
            public static System.Collections.Generic.List<cfg.skill.BulletTrackConfig> unmarshal_list_cfg_skill_BulletTrackConfig(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.skill.BulletTrackConfig>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_skill_BulletTrackConfig(os));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.level.ChapterBox> unmarshal_list_cfg_level_ChapterBox(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.level.ChapterBox>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_level_ChapterBox(os));
                            }return x;
                         }
            public static cfg.sound.Sound unmarshal_cfg_sound_Sound(Perfect.Marshal.Octets os) {
                            return new cfg.sound.Sound(os);
                         }
            public static cfg.hero.Hero unmarshal_cfg_hero_Hero(Perfect.Marshal.Octets os) {
                            return new cfg.hero.Hero(os);
                         }
            public static cfg.Vector2Int unmarshal_cfg_Vector2Int(Perfect.Marshal.Octets os) {
                            return new cfg.Vector2Int(os);
                         }
            public static System.Collections.Generic.List<cfg.battle.MapLevel> unmarshal_list_cfg_battle_MapLevel(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.battle.MapLevel>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_battle_MapLevel(os));
                            }return x;
                         }
            public static cfg.shop.EveryDayFreeGoods unmarshal_cfg_shop_EveryDayFreeGoods(Perfect.Marshal.Octets os) {
                            return new cfg.shop.EveryDayFreeGoods(os);
                         }
            public static cfg.attribute.AttributeLongNumber unmarshal_cfg_attribute_AttributeLongNumber(Perfect.Marshal.Octets os) {
                            return new cfg.attribute.AttributeLongNumber(os);
                         }
            public static cfg.common.XFloat unmarshal_cfg_common_XFloat(Perfect.Marshal.Octets os) {
                            return new cfg.common.XFloat(os);
                         }
            public static cfg.summon.SummonReward unmarshal_cfg_summon_SummonReward(Perfect.Marshal.Octets os) {
                            return new cfg.summon.SummonReward(os);
                         }
            public static cfg.asset.Asset unmarshal_cfg_asset_Asset(Perfect.Marshal.Octets os) {
                            return new cfg.asset.Asset(os);
                         }
            public static cfg.asset.AssetInfo unmarshal_cfg_asset_AssetInfo(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.asset.AssetInfo x;
                            switch(id) {
                            case 0: return null;
                            case 6998 : x = new cfg.asset.Texture(os); break;case 3106 : x = new cfg.asset.Sprite(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.function.AdGetCurrencyInfo unmarshal_cfg_function_AdGetCurrencyInfo(Perfect.Marshal.Octets os) {
                            return new cfg.function.AdGetCurrencyInfo(os);
                         }
            public static cfg.skill.StackNum unmarshal_cfg_skill_StackNum(Perfect.Marshal.Octets os) {
                            return new cfg.skill.StackNum(os);
                         }
            public static cfg.skill.Dizz unmarshal_cfg_skill_Dizz(Perfect.Marshal.Octets os) {
                            return new cfg.skill.Dizz(os);
                         }
            public static System.Collections.Generic.List<cfg.attribute.AttributeInfo> unmarshal_list_cfg_attribute_AttributeInfo(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.attribute.AttributeInfo>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_attribute_AttributeInfo(os));
                            }return x;
                         }
            public static cfg.battle.HeroTarget unmarshal_cfg_battle_HeroTarget(Perfect.Marshal.Octets os) {
                            return new cfg.battle.HeroTarget(os);
                         }
            public static System.Collections.Generic.List<cfg.skill.BulletConfig> unmarshal_list_cfg_skill_BulletConfig(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.skill.BulletConfig>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_skill_BulletConfig(os));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.item.Quality> unmarshal_list_cfg_item_Quality(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.item.Quality>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_item_Quality(os));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.RefreshWave> unmarshal_list_cfg_battle_RefreshWave(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.battle.RefreshWave>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_battle_RefreshWave(os));
                            }return x;
                         }
            public static cfg.shop.LimitByUser unmarshal_cfg_shop_LimitByUser(Perfect.Marshal.Octets os) {
                            return new cfg.shop.LimitByUser(os);
                         }
            public static cfg.global.GBool unmarshal_cfg_global_GBool(Perfect.Marshal.Octets os) {
                            return new cfg.global.GBool(os);
                         }
            public static cfg.shop.Shop unmarshal_cfg_shop_Shop(Perfect.Marshal.Octets os) {
                            return new cfg.shop.Shop(os);
                         }
            public static cfg.skill.HitInterval unmarshal_cfg_skill_HitInterval(Perfect.Marshal.Octets os) {
                            return new cfg.skill.HitInterval(os);
                         }
            public static cfg.bonus.MultiBonus unmarshal_cfg_bonus_MultiBonus(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.MultiBonus(os);
                         }
            public static cfg.skill.IntervalCheck unmarshal_cfg_skill_IntervalCheck(Perfect.Marshal.Octets os) {
                            return new cfg.skill.IntervalCheck(os);
                         }
            public static cfg.skill.InTerrain unmarshal_cfg_skill_InTerrain(Perfect.Marshal.Octets os) {
                            return new cfg.skill.InTerrain(os);
                         }
            public static cfg.function.JumpShopInfo unmarshal_cfg_function_JumpShopInfo(Perfect.Marshal.Octets os) {
                            return new cfg.function.JumpShopInfo(os);
                         }
            public static cfg.skill.TerrainAddBuff unmarshal_cfg_skill_TerrainAddBuff(Perfect.Marshal.Octets os) {
                            return new cfg.skill.TerrainAddBuff(os);
                         }
            public static System.Collections.Generic.List<cfg.map.MapPath> unmarshal_list_cfg_map_MapPath(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.map.MapPath>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_map_MapPath(os));
                            }return x;
                         }
            public static cfg.bonus.RandomBonus unmarshal_cfg_bonus_RandomBonus(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.RandomBonus(os);
                         }
            public static cfg.skill.ImmediateTrigger unmarshal_cfg_skill_ImmediateTrigger(Perfect.Marshal.Octets os) {
                            return new cfg.skill.ImmediateTrigger(os);
                         }
            public static cfg.common.XLong unmarshal_cfg_common_XLong(Perfect.Marshal.Octets os) {
                            return new cfg.common.XLong(os);
                         }
            public static cfg.skill.ReleaseSkill unmarshal_cfg_skill_ReleaseSkill(Perfect.Marshal.Octets os) {
                            return new cfg.skill.ReleaseSkill(os);
                         }
            public static cfg.skill.BeforeTakeBuffEffect unmarshal_cfg_skill_BeforeTakeBuffEffect(Perfect.Marshal.Octets os) {
                            return new cfg.skill.BeforeTakeBuffEffect(os);
                         }
            public static cfg.sysbuff.CastleAddAtkSlotSysBuff unmarshal_cfg_sysbuff_CastleAddAtkSlotSysBuff(Perfect.Marshal.Octets os) {
                            return new cfg.sysbuff.CastleAddAtkSlotSysBuff(os);
                         }
            public static cfg.bonus.WeightRandomBonus unmarshal_cfg_bonus_WeightRandomBonus(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.WeightRandomBonus(os);
                         }
            public static cfg.global.GInt32 unmarshal_cfg_global_GInt32(Perfect.Marshal.Octets os) {
                            return new cfg.global.GInt32(os);
                         }
            public static cfg.monster.Monster unmarshal_cfg_monster_Monster(Perfect.Marshal.Octets os) {
                            return new cfg.monster.Monster(os);
                         }
            public static cfg.battle.BuildingTower unmarshal_cfg_battle_BuildingTower(Perfect.Marshal.Octets os) {
                            return new cfg.battle.BuildingTower(os);
                         }
            public static cfg.skill.AfterTime unmarshal_cfg_skill_AfterTime(Perfect.Marshal.Octets os) {
                            return new cfg.skill.AfterTime(os);
                         }
            public static cfg.Vector2 unmarshal_cfg_Vector2(Perfect.Marshal.Octets os) {
                            return new cfg.Vector2(os);
                         }
            public static System.Collections.Generic.List<cfg.attribute.AttributeLongNumber> unmarshal_list_cfg_attribute_AttributeLongNumber(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.attribute.AttributeLongNumber>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_attribute_AttributeLongNumber(os));
                            }return x;
                         }
            public static cfg.common.AdCost unmarshal_cfg_common_AdCost(Perfect.Marshal.Octets os) {
                            return new cfg.common.AdCost(os);
                         }
            public static cfg.battle.RandomBuffLib unmarshal_cfg_battle_RandomBuffLib(Perfect.Marshal.Octets os) {
                            return new cfg.battle.RandomBuffLib(os);
                         }
            public static cfg.shop.NormalGoods unmarshal_cfg_shop_NormalGoods(Perfect.Marshal.Octets os) {
                            return new cfg.shop.NormalGoods(os);
                         }
            public static cfg.skill.StateDisappear unmarshal_cfg_skill_StateDisappear(Perfect.Marshal.Octets os) {
                            return new cfg.skill.StateDisappear(os);
                         }
            public static cfg.Vector3 unmarshal_cfg_Vector3(Perfect.Marshal.Octets os) {
                            return new cfg.Vector3(os);
                         }
            public static cfg.skill.BuffStatcking unmarshal_cfg_skill_BuffStatcking(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.skill.BuffStatcking x;
                            switch(id) {
                            case 0: return null;
                            case 33081 : x = new cfg.skill.StackNone(os); break;case 35619 : x = new cfg.skill.StackReset(os); break;case 43531 : x = new cfg.skill.StackNum(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.shop.CostType unmarshal_cfg_shop_CostType(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.shop.CostType x;
                            switch(id) {
                            case 0: return null;
                            case 38192 : x = new cfg.shop.CurrencyCost(os); break;case 41221 : x = new cfg.shop.Free(os); break;case 11115 : x = new cfg.shop.AdCost(os); break;case 8515 : x = new cfg.shop.MoneyCost(os); break;case 6141 : x = new cfg.shop.ItemCost(os); break;case 28540 : x = new cfg.shop.MultiCost(os); break;case 11098 : x = new cfg.shop.CostWithCount(os); break;case 963 : x = new cfg.shop.CostWithInterval(os); break;case 40045 : x = new cfg.shop.BatchCost(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.global.GlobalInfo unmarshal_cfg_global_GlobalInfo(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.global.GlobalInfo x;
                            switch(id) {
                            case 0: return null;
                            case 31643 : x = new cfg.global.GInt32(os); break;case 31738 : x = new cfg.global.GInt64(os); break;case 11475 : x = new cfg.global.GString(os); break;case 16276 : x = new cfg.global.GFloat(os); break;case 44923 : x = new cfg.global.GBool(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.condition.CastleLevel unmarshal_cfg_condition_CastleLevel(Perfect.Marshal.Octets os) {
                            return new cfg.condition.CastleLevel(os);
                         }
            public static cfg.condition.ChapterPass unmarshal_cfg_condition_ChapterPass(Perfect.Marshal.Octets os) {
                            return new cfg.condition.ChapterPass(os);
                         }
            public static System.Collections.Generic.List<cfg.global.Global> unmarshal_list_cfg_global_Global(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.global.Global>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_global_Global(os));
                            }return x;
                         }
            public static cfg.common.MoneyCost unmarshal_cfg_common_MoneyCost(Perfect.Marshal.Octets os) {
                            return new cfg.common.MoneyCost(os);
                         }
            public static System.Collections.Generic.List<cfg.tower.TowerSlot> unmarshal_list_cfg_tower_TowerSlot(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.tower.TowerSlot>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_tower_TowerSlot(os));
                            }return x;
                         }
            public static cfg.skill.FlyBullet unmarshal_cfg_skill_FlyBullet(Perfect.Marshal.Octets os) {
                            return new cfg.skill.FlyBullet(os);
                         }
            public static cfg.common.ItemCost unmarshal_cfg_common_ItemCost(Perfect.Marshal.Octets os) {
                            return new cfg.common.ItemCost(os);
                         }
            public static cfg.tower.TowerUpgradeNoBuffInfo unmarshal_cfg_tower_TowerUpgradeNoBuffInfo(Perfect.Marshal.Octets os) {
                            return new cfg.tower.TowerUpgradeNoBuffInfo(os);
                         }
            public static cfg.battle.RefreshBuffFree unmarshal_cfg_battle_RefreshBuffFree(Perfect.Marshal.Octets os) {
                            return new cfg.battle.RefreshBuffFree(os);
                         }
            public static cfg.shop.BatchCost unmarshal_cfg_shop_BatchCost(Perfect.Marshal.Octets os) {
                            return new cfg.shop.BatchCost(os);
                         }
            public static System.Collections.Generic.List<cfg.skill.BuffConfig> unmarshal_list_cfg_skill_BuffConfig(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.skill.BuffConfig>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_skill_BuffConfig(os));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.skill.BuffChangeContent> unmarshal_list_cfg_skill_BuffChangeContent(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.skill.BuffChangeContent>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_skill_BuffChangeContent(os));
                            }return x;
                         }
            public static cfg.shop.EveryDay unmarshal_cfg_shop_EveryDay(Perfect.Marshal.Octets os) {
                            return new cfg.shop.EveryDay(os);
                         }
            public static cfg.skill.Interval unmarshal_cfg_skill_Interval(Perfect.Marshal.Octets os) {
                            return new cfg.skill.Interval(os);
                         }
            public static cfg.sysbuff.SysBuffInfo unmarshal_cfg_sysbuff_SysBuffInfo(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.sysbuff.SysBuffInfo x;
                            switch(id) {
                            case 0: return null;
                            case 50462 : x = new cfg.sysbuff.TowerAttrSysBuff(os); break;case 9500 : x = new cfg.sysbuff.CastleAttrSysBuff(os); break;case 2534 : x = new cfg.sysbuff.BattleStartBuff(os); break;case 16486 : x = new cfg.sysbuff.CastleAddAtkSlotSysBuff(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.asset.Texture unmarshal_cfg_asset_Texture(Perfect.Marshal.Octets os) {
                            return new cfg.asset.Texture(os);
                         }
            public static System.Collections.Generic.List<cfg.map.LevelUp> unmarshal_list_cfg_map_LevelUp(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.map.LevelUp>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_map_LevelUp(os));
                            }return x;
                         }
            public static cfg.skill.DamageAdjust unmarshal_cfg_skill_DamageAdjust(Perfect.Marshal.Octets os) {
                            return new cfg.skill.DamageAdjust(os);
                         }
            public static cfg.function.JumpInfo unmarshal_cfg_function_JumpInfo(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.function.JumpInfo x;
                            switch(id) {
                            case 0: return null;
                            case 22130 : x = new cfg.function.JumpShopInfo(os); break;case 27082 : x = new cfg.function.JumpBattleInfo(os); break;case 39943 : x = new cfg.function.AdGetCurrencyInfo(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.MapBuild> unmarshal_list_cfg_battle_MapBuild(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.battle.MapBuild>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_battle_MapBuild(os));
                            }return x;
                         }
            public static cfg.bonus.RefBonus unmarshal_cfg_bonus_RefBonus(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.RefBonus(os);
                         }
            public static cfg.battle.RepeatCount unmarshal_cfg_battle_RepeatCount(Perfect.Marshal.Octets os) {
                            return new cfg.battle.RepeatCount(os);
                         }
            public static cfg.skill.InFixTime unmarshal_cfg_skill_InFixTime(Perfect.Marshal.Octets os) {
                            return new cfg.skill.InFixTime(os);
                         }
            public static cfg.skill.OtherControll unmarshal_cfg_skill_OtherControll(Perfect.Marshal.Octets os) {
                            return new cfg.skill.OtherControll(os);
                         }
            public static cfg.battle.TotalTowerTarget unmarshal_cfg_battle_TotalTowerTarget(Perfect.Marshal.Octets os) {
                            return new cfg.battle.TotalTowerTarget(os);
                         }
            public static System.Collections.Generic.List<cfg.monster.Monster> unmarshal_list_cfg_monster_Monster(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.monster.Monster>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_monster_Monster(os));
                            }return x;
                         }
            public static cfg.bonus.Currency unmarshal_cfg_bonus_Currency(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.Currency(os);
                         }
            public static cfg.sound.SoundEffect unmarshal_cfg_sound_SoundEffect(Perfect.Marshal.Octets os) {
                            return new cfg.sound.SoundEffect(os);
                         }
            public static System.Collections.Generic.List<cfg.shop.Shop> unmarshal_list_cfg_shop_Shop(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.shop.Shop>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_shop_Shop(os));
                            }return x;
                         }
            public static cfg.shop.LimitBuyType unmarshal_cfg_shop_LimitBuyType(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.shop.LimitBuyType x;
                            switch(id) {
                            case 0: return null;
                            case 24476 : x = new cfg.shop.NotLimit(os); break;case 44165 : x = new cfg.shop.LimitByUser(os); break;case 28248 : x = new cfg.shop.EveryDay(os); break;case 3227 : x = new cfg.shop.EveryWeek(os); break;case 19255 : x = new cfg.shop.EveryMonth(os); break;case 14314 : x = new cfg.shop.DayLimit(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.level.ChapterBox unmarshal_cfg_level_ChapterBox(Perfect.Marshal.Octets os) {
                            return new cfg.level.ChapterBox(os);
                         }
            public static cfg.castle.CastleUpgradeNoReward unmarshal_cfg_castle_CastleUpgradeNoReward(Perfect.Marshal.Octets os) {
                            return new cfg.castle.CastleUpgradeNoReward(os);
                         }
            public static System.Collections.Generic.List<cfg.shop.DailyDiscountWeight> unmarshal_list_cfg_shop_DailyDiscountWeight(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.shop.DailyDiscountWeight>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_shop_DailyDiscountWeight(os));
                            }return x;
                         }
            public static cfg.common.Cost unmarshal_cfg_common_Cost(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.common.Cost x;
                            switch(id) {
                            case 0: return null;
                            case 12910 : x = new cfg.common.None(os); break;case 37017 : x = new cfg.common.AdCost(os); break;case 21220 : x = new cfg.common.CurrencyCost(os); break;case 46930 : x = new cfg.common.ItemCost(os); break;case 8726 : x = new cfg.common.And(os); break;case 23102 : x = new cfg.common.Or(os); break;case 50266 : x = new cfg.common.MoneyCost(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.bonus.ItemId unmarshal_cfg_bonus_ItemId(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.ItemId(os);
                         }
            public static cfg.skill.HitSpTypeMonster unmarshal_cfg_skill_HitSpTypeMonster(Perfect.Marshal.Octets os) {
                            return new cfg.skill.HitSpTypeMonster(os);
                         }
            public static cfg.summon.SummonUpgrade unmarshal_cfg_summon_SummonUpgrade(Perfect.Marshal.Octets os) {
                            return new cfg.summon.SummonUpgrade(os);
                         }
            public static System.Collections.Generic.List<cfg.shop.GoodsInfo> unmarshal_list_cfg_shop_GoodsInfo(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.shop.GoodsInfo>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_shop_GoodsInfo(os));
                            }return x;
                         }
            public static cfg.shop.NotLimit unmarshal_cfg_shop_NotLimit(Perfect.Marshal.Octets os) {
                            return new cfg.shop.NotLimit(os);
                         }
            public static System.Collections.Generic.List<cfg.battle.RandomBuff> unmarshal_list_cfg_battle_RandomBuff(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.battle.RandomBuff>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_battle_RandomBuff(os));
                            }return x;
                         }
            public static cfg.tower.Tower unmarshal_cfg_tower_Tower(Perfect.Marshal.Octets os) {
                            return new cfg.tower.Tower(os);
                         }
            public static System.Collections.Generic.List<cfg.battle.SelectBuff> unmarshal_list_cfg_battle_SelectBuff(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.battle.SelectBuff>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_battle_SelectBuff(os));
                            }return x;
                         }
            public static cfg.battle.RefreshWave unmarshal_cfg_battle_RefreshWave(Perfect.Marshal.Octets os) {
                            return new cfg.battle.RefreshWave(os);
                         }
            public static cfg.common.XNumber unmarshal_cfg_common_XNumber(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.common.XNumber x;
                            switch(id) {
                            case 0: return null;
                            case 13651 : x = new cfg.common.XInt(os); break;case 5234 : x = new cfg.common.XLong(os); break;case 24592 : x = new cfg.common.XFloat(os); break;case 52174 : x = new cfg.common.XBigDecimal(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.bonus.Item> unmarshal_list_cfg_bonus_Item(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.bonus.Item>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_bonus_Item(os));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.error.Error> unmarshal_list_cfg_error_Error(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.error.Error>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_error_Error(os));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.RandomBuffLib> unmarshal_list_cfg_battle_RandomBuffLib(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.battle.RandomBuffLib>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_battle_RandomBuffLib(os));
                            }return x;
                         }
            public static cfg.common.CurrencyGlobal unmarshal_cfg_common_CurrencyGlobal(Perfect.Marshal.Octets os) {
                            return new cfg.common.CurrencyGlobal(os);
                         }
            public static cfg.battle.KillEnergyAdd unmarshal_cfg_battle_KillEnergyAdd(Perfect.Marshal.Octets os) {
                            return new cfg.battle.KillEnergyAdd(os);
                         }
            public static cfg.condition.OwnItem unmarshal_cfg_condition_OwnItem(Perfect.Marshal.Octets os) {
                            return new cfg.condition.OwnItem(os);
                         }
            public static cfg.skill.SplitBullet unmarshal_cfg_skill_SplitBullet(Perfect.Marshal.Octets os) {
                            return new cfg.skill.SplitBullet(os);
                         }
            public static cfg.condition.And unmarshal_cfg_condition_And(Perfect.Marshal.Octets os) {
                            return new cfg.condition.And(os);
                         }
            public static System.Collections.Generic.List<cfg.shop.DailyGoodsRefresh> unmarshal_list_cfg_shop_DailyGoodsRefresh(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.shop.DailyGoodsRefresh>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_shop_DailyGoodsRefresh(os));
                            }return x;
                         }
            public static System.Collections.Generic.List<int> unmarshal_list_int(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<int>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(os.ReadInt());
                            }return x;
                         }
            public static cfg.castle.CastleSkillUpgradeInfo unmarshal_cfg_castle_CastleSkillUpgradeInfo(Perfect.Marshal.Octets os) {
                            return new cfg.castle.CastleSkillUpgradeInfo(os);
                         }
            public static cfg.item.Quality unmarshal_cfg_item_Quality(Perfect.Marshal.Octets os) {
                            return new cfg.item.Quality(os);
                         }
            public static cfg.skill.HitTarget unmarshal_cfg_skill_HitTarget(Perfect.Marshal.Octets os) {
                            return new cfg.skill.HitTarget(os);
                         }
            public static System.Collections.Generic.List<cfg.sysbuff.SysBuff> unmarshal_list_cfg_sysbuff_SysBuff(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.sysbuff.SysBuff>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_sysbuff_SysBuff(os));
                            }return x;
                         }
            public static cfg.shop.DayLimit unmarshal_cfg_shop_DayLimit(Perfect.Marshal.Octets os) {
                            return new cfg.shop.DayLimit(os);
                         }
            public static System.Collections.Generic.List<cfg.shop.DailyGoods> unmarshal_list_cfg_shop_DailyGoods(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.shop.DailyGoods>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_shop_DailyGoods(os));
                            }return x;
                         }
            public static cfg.shop.DailyGoodsRefresh unmarshal_cfg_shop_DailyGoodsRefresh(Perfect.Marshal.Octets os) {
                            return new cfg.shop.DailyGoodsRefresh(os);
                         }
            public static System.Collections.Generic.List<cfg.item.Item> unmarshal_list_cfg_item_Item(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.item.Item>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_item_Item(os));
                            }return x;
                         }
            public static cfg.skill.Immediate unmarshal_cfg_skill_Immediate(Perfect.Marshal.Octets os) {
                            return new cfg.skill.Immediate(os);
                         }
            public static System.Collections.Generic.List<cfg.tower.TowerUpgrade> unmarshal_list_cfg_tower_TowerUpgrade(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.tower.TowerUpgrade>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_tower_TowerUpgrade(os));
                            }return x;
                         }
            public static cfg.tower.LockSlot unmarshal_cfg_tower_LockSlot(Perfect.Marshal.Octets os) {
                            return new cfg.tower.LockSlot(os);
                         }
            public static cfg.shop.WeeklyRefresh unmarshal_cfg_shop_WeeklyRefresh(Perfect.Marshal.Octets os) {
                            return new cfg.shop.WeeklyRefresh(os);
                         }
            public static cfg.skill.NoramlRelease unmarshal_cfg_skill_NoramlRelease(Perfect.Marshal.Octets os) {
                            return new cfg.skill.NoramlRelease(os);
                         }
            public static System.Collections.Generic.List<cfg.tower.Tower> unmarshal_list_cfg_tower_Tower(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.tower.Tower>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_tower_Tower(os));
                            }return x;
                         }
            public static cfg.shop.Free unmarshal_cfg_shop_Free(Perfect.Marshal.Octets os) {
                            return new cfg.shop.Free(os);
                         }
            public static System.Collections.Generic.List<cfg.skill.SkillReleaseConfig> unmarshal_list_cfg_skill_SkillReleaseConfig(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.skill.SkillReleaseConfig>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_skill_SkillReleaseConfig(os));
                            }return x;
                         }
            public static cfg.skill.BuffChange unmarshal_cfg_skill_BuffChange(Perfect.Marshal.Octets os) {
                            return new cfg.skill.BuffChange(os);
                         }
            public static cfg.skill.CreateBulletDataFinish unmarshal_cfg_skill_CreateBulletDataFinish(Perfect.Marshal.Octets os) {
                            return new cfg.skill.CreateBulletDataFinish(os);
                         }
            public static System.Collections.Generic.List<cfg.localize.TexLocalizeElement> unmarshal_list_cfg_localize_TexLocalizeElement(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.localize.TexLocalizeElement>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_localize_TexLocalizeElement(os));
                            }return x;
                         }
            public static cfg.localize.TexAssetElement unmarshal_cfg_localize_TexAssetElement(Perfect.Marshal.Octets os) {
                            return new cfg.localize.TexAssetElement(os);
                         }
            public static cfg.battle.AddQualityAboveBuffWeight unmarshal_cfg_battle_AddQualityAboveBuffWeight(Perfect.Marshal.Octets os) {
                            return new cfg.battle.AddQualityAboveBuffWeight(os);
                         }
            public static cfg.skill.BulletDestroyType unmarshal_cfg_skill_BulletDestroyType(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.skill.BulletDestroyType x;
                            switch(id) {
                            case 0: return null;
                            case 63888 : x = new cfg.skill.EffectOnce(os); break;case 24046 : x = new cfg.skill.EffectNum(os); break;case 52790 : x = new cfg.skill.EffectUnlimit(os); break;case 51293 : x = new cfg.skill.AfterTime(os); break;case 13765 : x = new cfg.skill.OtherControll(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.shop.DailyDiscountWeight unmarshal_cfg_shop_DailyDiscountWeight(Perfect.Marshal.Octets os) {
                            return new cfg.shop.DailyDiscountWeight(os);
                         }
            public static cfg.sysbuff.TowerAttrSysBuff unmarshal_cfg_sysbuff_TowerAttrSysBuff(Perfect.Marshal.Octets os) {
                            return new cfg.sysbuff.TowerAttrSysBuff(os);
                         }
            public static cfg.global.Global unmarshal_cfg_global_Global(Perfect.Marshal.Octets os) {
                            return new cfg.global.Global(os);
                         }
            public static System.Collections.Generic.List<cfg.shop.CostType> unmarshal_list_cfg_shop_CostType(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.shop.CostType>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_shop_CostType(os));
                            }return x;
                         }
            public static System.Collections.Generic.Dictionary<int,cfg.castle.CastleSkillUpgradeInfo> unmarshal_map_int_cfg_castle_CastleSkillUpgradeInfo(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.Dictionary<int,cfg.castle.CastleSkillUpgradeInfo>(n * 7 / 5);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(os.ReadInt(), cfg.Extensions.unmarshal_cfg_castle_CastleSkillUpgradeInfo(os));
                            }return x;
                         }
            public static cfg.castle.Castle unmarshal_cfg_castle_Castle(Perfect.Marshal.Octets os) {
                            return new cfg.castle.Castle(os);
                         }
            public static cfg.sysbuff.SysBuff unmarshal_cfg_sysbuff_SysBuff(Perfect.Marshal.Octets os) {
                            return new cfg.sysbuff.SysBuff(os);
                         }
            public static cfg.skill.AfterTakeBuffEffect unmarshal_cfg_skill_AfterTakeBuffEffect(Perfect.Marshal.Octets os) {
                            return new cfg.skill.AfterTakeBuffEffect(os);
                         }
            public static cfg.shop.DailyShopInfo unmarshal_cfg_shop_DailyShopInfo(Perfect.Marshal.Octets os) {
                            return new cfg.shop.DailyShopInfo(os);
                         }
            public static cfg.battle.StartBuff unmarshal_cfg_battle_StartBuff(Perfect.Marshal.Octets os) {
                            return new cfg.battle.StartBuff(os);
                         }
            public static cfg.bonus.Items unmarshal_cfg_bonus_Items(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.Items(os);
                         }
            public static System.Collections.Generic.List<cfg.condition.Condition> unmarshal_list_cfg_condition_Condition(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.condition.Condition>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_condition_Condition(os));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.shop.SellInfo> unmarshal_list_cfg_shop_SellInfo(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.shop.SellInfo>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_shop_SellInfo(os));
                            }return x;
                         }
            public static cfg.localize.TexLocalizeElement unmarshal_cfg_localize_TexLocalizeElement(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.localize.TexLocalizeElement x;
                            switch(id) {
                            case 0: return null;
                            case 31510 : x = new cfg.localize.TexAssetElement(os); break;case 17934 : x = new cfg.localize.TexLocalizeElements(os); break;case 32342 : x = new cfg.localize.TexPositionElement(os); break;case 23750 : x = new cfg.localize.TexScaleElement(os); break;case 14865 : x = new cfg.localize.TexSizeElement(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.skill.SkillReleaseConfig unmarshal_cfg_skill_SkillReleaseConfig(Perfect.Marshal.Octets os) {
                            return new cfg.skill.SkillReleaseConfig(os);
                         }
            public static cfg.level.BattleLevel unmarshal_cfg_level_BattleLevel(Perfect.Marshal.Octets os) {
                            return new cfg.level.BattleLevel(os);
                         }
            public static cfg.battle.MapLevel unmarshal_cfg_battle_MapLevel(Perfect.Marshal.Octets os) {
                            return new cfg.battle.MapLevel(os);
                         }
            public static cfg.bonus.RandomTowerFragmentQuality unmarshal_cfg_bonus_RandomTowerFragmentQuality(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.RandomTowerFragmentQuality(os);
                         }
            public static System.Collections.Generic.List<cfg.bonus.WeightBonus> unmarshal_list_cfg_bonus_WeightBonus(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.bonus.WeightBonus>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_bonus_WeightBonus(os));
                            }return x;
                         }
            public static cfg.global.GString unmarshal_cfg_global_GString(Perfect.Marshal.Octets os) {
                            return new cfg.global.GString(os);
                         }
            public static cfg.castle.CastleUpgradeBonusReward unmarshal_cfg_castle_CastleUpgradeBonusReward(Perfect.Marshal.Octets os) {
                            return new cfg.castle.CastleUpgradeBonusReward(os);
                         }
            public static System.Collections.Generic.Dictionary<cfg.localize.ELanguageType,cfg.localize.TexLocalizeElement> unmarshal_map_cfg_localize_ELanguageType_cfg_localize_TexLocalizeElement(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.Dictionary<cfg.localize.ELanguageType,cfg.localize.TexLocalizeElement>(n * 7 / 5);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add((cfg.localize.ELanguageType)(os.ReadInt()), cfg.Extensions.unmarshal_cfg_localize_TexLocalizeElement(os));
                            }return x;
                         }
            public static cfg.skill.PathBullet unmarshal_cfg_skill_PathBullet(Perfect.Marshal.Octets os) {
                            return new cfg.skill.PathBullet(os);
                         }
            public static cfg.skill.BulletEffectType unmarshal_cfg_skill_BulletEffectType(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.skill.BulletEffectType x;
                            switch(id) {
                            case 0: return null;
                            case 63938 : x = new cfg.skill.HitFixTarget(os); break;case 60405 : x = new cfg.skill.HitAnyOne(os); break;case 47063 : x = new cfg.skill.HitImmediate(os); break;case 16968 : x = new cfg.skill.HitDelay(os); break;case 54645 : x = new cfg.skill.HitInterval(os); break;case 25225 : x = new cfg.skill.IntervalCheck(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.StartBuff> unmarshal_list_cfg_battle_StartBuff(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.battle.StartBuff>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_battle_StartBuff(os));
                            }return x;
                         }
            public static cfg.skill.BulletChange unmarshal_cfg_skill_BulletChange(Perfect.Marshal.Octets os) {
                            return new cfg.skill.BulletChange(os);
                         }
            public static System.Collections.Generic.List<cfg.castle.CastleAttrUpInfo> unmarshal_list_cfg_castle_CastleAttrUpInfo(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.castle.CastleAttrUpInfo>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_castle_CastleAttrUpInfo(os));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.localize.TextureLanguage> unmarshal_list_cfg_localize_TextureLanguage(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.localize.TextureLanguage>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_localize_TextureLanguage(os));
                            }return x;
                         }
            public static cfg.tower.DefaultTowerSlot unmarshal_cfg_tower_DefaultTowerSlot(Perfect.Marshal.Octets os) {
                            return new cfg.tower.DefaultTowerSlot(os);
                         }
            public static cfg.skill.AttributeChange unmarshal_cfg_skill_AttributeChange(Perfect.Marshal.Octets os) {
                            return new cfg.skill.AttributeChange(os);
                         }
            public static System.Collections.Generic.List<cfg.battle.RefreshMonster> unmarshal_list_cfg_battle_RefreshMonster(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.battle.RefreshMonster>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_battle_RefreshMonster(os));
                            }return x;
                         }
            public static cfg.battle.SelectBuff unmarshal_cfg_battle_SelectBuff(Perfect.Marshal.Octets os) {
                            return new cfg.battle.SelectBuff(os);
                         }
            public static cfg.shop.SellItem unmarshal_cfg_shop_SellItem(Perfect.Marshal.Octets os) {
                            return new cfg.shop.SellItem(os);
                         }
            public static cfg.skill.BuffTriggerType unmarshal_cfg_skill_BuffTriggerType(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.skill.BuffTriggerType x;
                            switch(id) {
                            case 0: return null;
                            case 27531 : x = new cfg.skill.ImmediateTrigger(os); break;case 55546 : x = new cfg.skill.HitTarget(os); break;case 17015 : x = new cfg.skill.ReleaseBullet(os); break;case 53388 : x = new cfg.skill.ReleaseSkill(os); break;case 63727 : x = new cfg.skill.CreateBulletDataFinish(os); break;case 42104 : x = new cfg.skill.BeforeTakeBuffEffect(os); break;case 15639 : x = new cfg.skill.AfterTakeBuffEffect(os); break;case 29762 : x = new cfg.skill.BeforeDeadHaveState(os); break;case 30508 : x = new cfg.skill.HitStateTarget(os); break;case 41057 : x = new cfg.skill.HitSpTypeMonster(os); break;case 32625 : x = new cfg.skill.InTerrain(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.skill.HitStateTarget unmarshal_cfg_skill_HitStateTarget(Perfect.Marshal.Octets os) {
                            return new cfg.skill.HitStateTarget(os);
                         }
            public static cfg.condition.Currency unmarshal_cfg_condition_Currency(Perfect.Marshal.Octets os) {
                            return new cfg.condition.Currency(os);
                         }
            public static cfg.condition.Condition unmarshal_cfg_condition_Condition(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.condition.Condition x;
                            switch(id) {
                            case 0: return null;
                            case 51733 : x = new cfg.condition.None(os); break;case 53049 : x = new cfg.condition.Currency(os); break;case 65080 : x = new cfg.condition.Item(os); break;case 28544 : x = new cfg.condition.BuyMonthlyCard(os); break;case 23955 : x = new cfg.condition.OwnItem(os); break;case 52819 : x = new cfg.condition.ChapterPass(os); break;case 1197 : x = new cfg.condition.CastleLevel(os); break;case 28076 : x = new cfg.condition.And(os); break;case 24596 : x = new cfg.condition.Or(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.bonus.Bonus> unmarshal_list_cfg_bonus_Bonus(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.bonus.Bonus>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_bonus_Bonus(os));
                            }return x;
                         }
            public static cfg.battle.EffectTarget unmarshal_cfg_battle_EffectTarget(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.battle.EffectTarget x;
                            switch(id) {
                            case 0: return null;
                            case 1940 : x = new cfg.battle.CastleTarget(os); break;case 39296 : x = new cfg.battle.HeroTarget(os); break;case 2608 : x = new cfg.battle.SingeTowerTarget(os); break;case 53180 : x = new cfg.battle.SpDamageTypeTowerTarget(os); break;case 26833 : x = new cfg.battle.TotalTowerTarget(os); break;case 29593 : x = new cfg.battle.EnemyTarget(os); break;case 55366 : x = new cfg.battle.GlobalTarget(os); break;case 54777 : x = new cfg.battle.KillExpAdd(os); break;case 12207 : x = new cfg.battle.KillEnergyAdd(os); break;case 26679 : x = new cfg.battle.MoneyWaveAdd(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.skill.Forever unmarshal_cfg_skill_Forever(Perfect.Marshal.Octets os) {
                            return new cfg.skill.Forever(os);
                         }
            public static cfg.common.Currency unmarshal_cfg_common_Currency(Perfect.Marshal.Octets os) {
                            return new cfg.common.Currency(os);
                         }
            public static cfg.common.CurrencyCost unmarshal_cfg_common_CurrencyCost(Perfect.Marshal.Octets os) {
                            return new cfg.common.CurrencyCost(os);
                         }
            public static cfg.skill.StackReset unmarshal_cfg_skill_StackReset(Perfect.Marshal.Octets os) {
                            return new cfg.skill.StackReset(os);
                         }
            public static System.Collections.Generic.List<cfg.bonus.BonusData> unmarshal_list_cfg_bonus_BonusData(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.bonus.BonusData>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_bonus_BonusData(os));
                            }return x;
                         }
            public static cfg.bonus.Empty unmarshal_cfg_bonus_Empty(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.Empty(os);
                         }
            public static cfg.attribute.AttributeInfo unmarshal_cfg_attribute_AttributeInfo(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.attribute.AttributeInfo x;
                            switch(id) {
                            case 0: return null;
                            case 24919 : x = new cfg.attribute.None(os); break;case 20666 : x = new cfg.attribute.AttributeNumber(os); break;case 35280 : x = new cfg.attribute.AttributeLongNumber(os); break;case 43740 : x = new cfg.attribute.And(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.castle.CastleUpgrade> unmarshal_list_cfg_castle_CastleUpgrade(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.castle.CastleUpgrade>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_castle_CastleUpgrade(os));
                            }return x;
                         }
            public static cfg.common.XInt unmarshal_cfg_common_XInt(Perfect.Marshal.Octets os) {
                            return new cfg.common.XInt(os);
                         }
            public static cfg.item.TowerFragmentInfo unmarshal_cfg_item_TowerFragmentInfo(Perfect.Marshal.Octets os) {
                            return new cfg.item.TowerFragmentInfo(os);
                         }
            public static cfg.shop.SellGift unmarshal_cfg_shop_SellGift(Perfect.Marshal.Octets os) {
                            return new cfg.shop.SellGift(os);
                         }
            public static cfg.skill.BeamBullet unmarshal_cfg_skill_BeamBullet(Perfect.Marshal.Octets os) {
                            return new cfg.skill.BeamBullet(os);
                         }
            public static cfg.skill.StackNone unmarshal_cfg_skill_StackNone(Perfect.Marshal.Octets os) {
                            return new cfg.skill.StackNone(os);
                         }
            public static cfg.skill.AttackDamage unmarshal_cfg_skill_AttackDamage(Perfect.Marshal.Octets os) {
                            return new cfg.skill.AttackDamage(os);
                         }
            public static cfg.battle.BuildingRoad unmarshal_cfg_battle_BuildingRoad(Perfect.Marshal.Octets os) {
                            return new cfg.battle.BuildingRoad(os);
                         }
            public static System.Collections.Generic.List<cfg.user.UserTitle> unmarshal_list_cfg_user_UserTitle(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.user.UserTitle>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_user_UserTitle(os));
                            }return x;
                         }
            public static cfg.condition.BuyMonthlyCard unmarshal_cfg_condition_BuyMonthlyCard(Perfect.Marshal.Octets os) {
                            return new cfg.condition.BuyMonthlyCard(os);
                         }
            public static System.Collections.Generic.Dictionary<cfg.summon.ESummonType,cfg.bonus.Bonus> unmarshal_map_cfg_summon_ESummonType_cfg_bonus_Bonus(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.Dictionary<cfg.summon.ESummonType,cfg.bonus.Bonus>(n * 7 / 5);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add((cfg.summon.ESummonType)(os.ReadInt()), cfg.Extensions.unmarshal_cfg_bonus_Bonus(os));
                            }return x;
                         }
            public static cfg.tower.Empty unmarshal_cfg_tower_Empty(Perfect.Marshal.Octets os) {
                            return new cfg.tower.Empty(os);
                         }
            public static cfg.skill.ReleaseNumCritical unmarshal_cfg_skill_ReleaseNumCritical(Perfect.Marshal.Octets os) {
                            return new cfg.skill.ReleaseNumCritical(os);
                         }
            public static cfg.sound.Music unmarshal_cfg_sound_Music(Perfect.Marshal.Octets os) {
                            return new cfg.sound.Music(os);
                         }
            public static System.Collections.Generic.Dictionary<int,cfg.castle.AttrUpgradeInfo> unmarshal_map_int_cfg_castle_AttrUpgradeInfo(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.Dictionary<int,cfg.castle.AttrUpgradeInfo>(n * 7 / 5);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(os.ReadInt(), cfg.Extensions.unmarshal_cfg_castle_AttrUpgradeInfo(os));
                            }return x;
                         }
            public static cfg.skill.ReleaseBullet unmarshal_cfg_skill_ReleaseBullet(Perfect.Marshal.Octets os) {
                            return new cfg.skill.ReleaseBullet(os);
                         }
            public static System.Collections.Generic.List<cfg.castle.CastleSkill> unmarshal_list_cfg_castle_CastleSkill(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.castle.CastleSkill>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_castle_CastleSkill(os));
                            }return x;
                         }
            public static cfg.shop.MultiCost unmarshal_cfg_shop_MultiCost(Perfect.Marshal.Octets os) {
                            return new cfg.shop.MultiCost(os);
                         }
            public static System.Collections.Generic.List<cfg.map.OutDirFilterAdd> unmarshal_list_cfg_map_OutDirFilterAdd(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.map.OutDirFilterAdd>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_map_OutDirFilterAdd(os));
                            }return x;
                         }
            public static cfg.castle.CastleAttrUpInfo unmarshal_cfg_castle_CastleAttrUpInfo(Perfect.Marshal.Octets os) {
                            return new cfg.castle.CastleAttrUpInfo(os);
                         }
            public static System.Collections.Generic.List<cfg.map.mapEvent> unmarshal_list_cfg_map_mapEvent(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.map.mapEvent>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_map_mapEvent(os));
                            }return x;
                         }
            public static cfg.skill.ReleasePlusBullet unmarshal_cfg_skill_ReleasePlusBullet(Perfect.Marshal.Octets os) {
                            return new cfg.skill.ReleasePlusBullet(os);
                         }
            public static cfg.skill.EffectOnce unmarshal_cfg_skill_EffectOnce(Perfect.Marshal.Octets os) {
                            return new cfg.skill.EffectOnce(os);
                         }
            public static cfg.global.GFloat unmarshal_cfg_global_GFloat(Perfect.Marshal.Octets os) {
                            return new cfg.global.GFloat(os);
                         }
            public static cfg.battle.CastleTarget unmarshal_cfg_battle_CastleTarget(Perfect.Marshal.Octets os) {
                            return new cfg.battle.CastleTarget(os);
                         }
            public static cfg.item.SummonInfo unmarshal_cfg_item_SummonInfo(Perfect.Marshal.Octets os) {
                            return new cfg.item.SummonInfo(os);
                         }
            public static cfg.shop.AdCost unmarshal_cfg_shop_AdCost(Perfect.Marshal.Octets os) {
                            return new cfg.shop.AdCost(os);
                         }
            public static cfg.localize.TextureLanguage unmarshal_cfg_localize_TextureLanguage(Perfect.Marshal.Octets os) {
                            return new cfg.localize.TextureLanguage(os);
                         }
            public static cfg.battle.BuildingType unmarshal_cfg_battle_BuildingType(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.battle.BuildingType x;
                            switch(id) {
                            case 0: return null;
                            case 4992 : x = new cfg.battle.BuildingRoad(os); break;case 55911 : x = new cfg.battle.BuildingTower(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.skill.SkillPropertyChange unmarshal_cfg_skill_SkillPropertyChange(Perfect.Marshal.Octets os) {
                            return new cfg.skill.SkillPropertyChange(os);
                         }
            public static cfg.skill.ReleaseFlashBullet unmarshal_cfg_skill_ReleaseFlashBullet(Perfect.Marshal.Octets os) {
                            return new cfg.skill.ReleaseFlashBullet(os);
                         }
            public static cfg.tower.SlotInfo unmarshal_cfg_tower_SlotInfo(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.tower.SlotInfo x;
                            switch(id) {
                            case 0: return null;
                            case 48255 : x = new cfg.tower.Empty(os); break;case 11452 : x = new cfg.tower.DefaultTowerSlot(os); break;case 6908 : x = new cfg.tower.LockSlot(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.tower.TowerUpgrade unmarshal_cfg_tower_TowerUpgrade(Perfect.Marshal.Octets os) {
                            return new cfg.tower.TowerUpgrade(os);
                         }
            public static System.Collections.Generic.List<cfg.summon.Summon> unmarshal_list_cfg_summon_Summon(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.summon.Summon>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_summon_Summon(os));
                            }return x;
                         }
            public static cfg.battle.BattleRefresh unmarshal_cfg_battle_BattleRefresh(Perfect.Marshal.Octets os) {
                            return new cfg.battle.BattleRefresh(os);
                         }
            public static System.Collections.Generic.List<cfg.map.MapGround> unmarshal_list_cfg_map_MapGround(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.map.MapGround>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_map_MapGround(os));
                            }return x;
                         }
            public static cfg.shop.EveryWeek unmarshal_cfg_shop_EveryWeek(Perfect.Marshal.Octets os) {
                            return new cfg.shop.EveryWeek(os);
                         }
            public static cfg.map.mapEvent unmarshal_cfg_map_mapEvent(Perfect.Marshal.Octets os) {
                            return new cfg.map.mapEvent(os);
                         }
            public static cfg.common.None unmarshal_cfg_common_None(Perfect.Marshal.Octets os) {
                            return new cfg.common.None(os);
                         }
            public static cfg.shop.NromalShopInfo unmarshal_cfg_shop_NromalShopInfo(Perfect.Marshal.Octets os) {
                            return new cfg.shop.NromalShopInfo(os);
                         }
            public static cfg.bonus.Bonus unmarshal_cfg_bonus_Bonus(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.bonus.Bonus x;
                            switch(id) {
                            case 0: return null;
                            case 18584 : x = new cfg.bonus.Empty(os); break;case 31944 : x = new cfg.bonus.RefBonus(os); break;case 46927 : x = new cfg.bonus.Currency(os); break;case 21920 : x = new cfg.bonus.ItemId(os); break;case 9164 : x = new cfg.bonus.Item(os); break;case 43728 : x = new cfg.bonus.Items(os); break;case 12489 : x = new cfg.bonus.RandomTowerFragmentQuality(os); break;case 11336 : x = new cfg.bonus.WeightBonus(os); break;case 6547 : x = new cfg.bonus.RandomBonus(os); break;case 17310 : x = new cfg.bonus.WeightRandomBonus(os); break;case 57487 : x = new cfg.bonus.MultiBonus(os); break;case 56236 : x = new cfg.bonus.RepeatBonus(os); break;case 37837 : x = new cfg.bonus.CopyBonus(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.common.Currency> unmarshal_list_cfg_common_Currency(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.common.Currency>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_common_Currency(os));
                            }return x;
                         }
            public static cfg.battle.EnemyTarget unmarshal_cfg_battle_EnemyTarget(Perfect.Marshal.Octets os) {
                            return new cfg.battle.EnemyTarget(os);
                         }
            public static cfg.attribute.Attribute unmarshal_cfg_attribute_Attribute(Perfect.Marshal.Octets os) {
                            return new cfg.attribute.Attribute(os);
                         }
            public static cfg.castle.AttrUpgradeInfo unmarshal_cfg_castle_AttrUpgradeInfo(Perfect.Marshal.Octets os) {
                            return new cfg.castle.AttrUpgradeInfo(os);
                         }
            public static cfg.attribute.None unmarshal_cfg_attribute_None(Perfect.Marshal.Octets os) {
                            return new cfg.attribute.None(os);
                         }
            public static cfg.castle.CastleUpgrade unmarshal_cfg_castle_CastleUpgrade(Perfect.Marshal.Octets os) {
                            return new cfg.castle.CastleUpgrade(os);
                         }
            public static cfg.skill.BuffEffectContent unmarshal_cfg_skill_BuffEffectContent(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.skill.BuffEffectContent x;
                            switch(id) {
                            case 0: return null;
                            case 32442 : x = new cfg.skill.AttributeChange(os); break;case 57409 : x = new cfg.skill.DamageAdjust(os); break;case 46536 : x = new cfg.skill.HpChange(os); break;case 32891 : x = new cfg.skill.SkillPropertyChange(os); break;case 58996 : x = new cfg.skill.ReleasePlusBullet(os); break;case 59923 : x = new cfg.skill.SplitBullet(os); break;case 12103 : x = new cfg.skill.BulletChange(os); break;case 27921 : x = new cfg.skill.BuffChange(os); break;case 16184 : x = new cfg.skill.AOEPlusDamage(os); break;case 48121 : x = new cfg.skill.Fire(os); break;case 13309 : x = new cfg.skill.Frozen(os); break;case 41897 : x = new cfg.skill.Dizz(os); break;case 47801 : x = new cfg.skill.HitBack(os); break;case 7293 : x = new cfg.skill.ReleaseFlashBullet(os); break;case 46852 : x = new cfg.skill.AttackDamage(os); break;case 53274 : x = new cfg.skill.AddBuff(os); break;case 36723 : x = new cfg.skill.TerrainAddBuff(os); break;case 4733 : x = new cfg.skill.ReleaseNumCritical(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.common.Cost> unmarshal_list_cfg_common_Cost(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.common.Cost>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_common_Cost(os));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.hero.Hero> unmarshal_list_cfg_hero_Hero(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.hero.Hero>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_hero_Hero(os));
                            }return x;
                         }
            public static cfg.common.Or unmarshal_cfg_common_Or(Perfect.Marshal.Octets os) {
                            return new cfg.common.Or(os);
                         }
            public static cfg.localize.TexScaleElement unmarshal_cfg_localize_TexScaleElement(Perfect.Marshal.Octets os) {
                            return new cfg.localize.TexScaleElement(os);
                         }
            public static cfg.bonus.BonusData unmarshal_cfg_bonus_BonusData(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.BonusData(os);
                         }
            public static System.Collections.Generic.List<cfg.battle.BattleAsset> unmarshal_list_cfg_battle_BattleAsset(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.battle.BattleAsset>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_battle_BattleAsset(os));
                            }return x;
                         }
            public static cfg.bonus.WeightBonus unmarshal_cfg_bonus_WeightBonus(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.WeightBonus(os);
                         }
            public static cfg.skill.AOEPlusDamage unmarshal_cfg_skill_AOEPlusDamage(Perfect.Marshal.Octets os) {
                            return new cfg.skill.AOEPlusDamage(os);
                         }
            public static cfg.skill.HitBack unmarshal_cfg_skill_HitBack(Perfect.Marshal.Octets os) {
                            return new cfg.skill.HitBack(os);
                         }
            public static cfg.battle.BattleIncomeAdd unmarshal_cfg_battle_BattleIncomeAdd(Perfect.Marshal.Octets os) {
                            return new cfg.battle.BattleIncomeAdd(os);
                         }
            public static cfg.battle.SpDamageTypeTowerTarget unmarshal_cfg_battle_SpDamageTypeTowerTarget(Perfect.Marshal.Octets os) {
                            return new cfg.battle.SpDamageTypeTowerTarget(os);
                         }
            public static System.Collections.Generic.List<cfg.battle.RandomBuffLibContent> unmarshal_list_cfg_battle_RandomBuffLibContent(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.battle.RandomBuffLibContent>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_battle_RandomBuffLibContent(os));
                            }return x;
                         }
            public static cfg.shop.NotRefresh unmarshal_cfg_shop_NotRefresh(Perfect.Marshal.Octets os) {
                            return new cfg.shop.NotRefresh(os);
                         }
            public static cfg.attribute.AttributeNumber unmarshal_cfg_attribute_AttributeNumber(Perfect.Marshal.Octets os) {
                            return new cfg.attribute.AttributeNumber(os);
                         }
            public static cfg.skill.SkillReleaseType unmarshal_cfg_skill_SkillReleaseType(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.skill.SkillReleaseType x;
                            switch(id) {
                            case 0: return null;
                            case 38660 : x = new cfg.skill.NoramlRelease(os); break;case 50220 : x = new cfg.skill.ReleaseBuff(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.shop.EveryMonth unmarshal_cfg_shop_EveryMonth(Perfect.Marshal.Octets os) {
                            return new cfg.shop.EveryMonth(os);
                         }
            public static cfg.shop.CurrencyCost unmarshal_cfg_shop_CurrencyCost(Perfect.Marshal.Octets os) {
                            return new cfg.shop.CurrencyCost(os);
                         }
            public static cfg.skill.BuffEffectType unmarshal_cfg_skill_BuffEffectType(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.skill.BuffEffectType x;
                            switch(id) {
                            case 0: return null;
                            case 64257 : x = new cfg.skill.Immediate(os); break;case 9748 : x = new cfg.skill.Delay(os); break;case 46743 : x = new cfg.skill.Interval(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.bonus.RepeatBonus unmarshal_cfg_bonus_RepeatBonus(Perfect.Marshal.Octets os) {
                            return new cfg.bonus.RepeatBonus(os);
                         }
            public static cfg.map.LevelUp unmarshal_cfg_map_LevelUp(Perfect.Marshal.Octets os) {
                            return new cfg.map.LevelUp(os);
                         }
            public static cfg.condition.Item unmarshal_cfg_condition_Item(Perfect.Marshal.Octets os) {
                            return new cfg.condition.Item(os);
                         }
            public static cfg.attribute.And unmarshal_cfg_attribute_And(Perfect.Marshal.Octets os) {
                            return new cfg.attribute.And(os);
                         }
            public static cfg.item.GiftInfo unmarshal_cfg_item_GiftInfo(Perfect.Marshal.Octets os) {
                            return new cfg.item.GiftInfo(os);
                         }
            public static cfg.skill.AfterExcute unmarshal_cfg_skill_AfterExcute(Perfect.Marshal.Octets os) {
                            return new cfg.skill.AfterExcute(os);
                         }
            public static cfg.asset.Sprite unmarshal_cfg_asset_Sprite(Perfect.Marshal.Octets os) {
                            return new cfg.asset.Sprite(os);
                         }
            public static cfg.sysbuff.CastleAttrSysBuff unmarshal_cfg_sysbuff_CastleAttrSysBuff(Perfect.Marshal.Octets os) {
                            return new cfg.sysbuff.CastleAttrSysBuff(os);
                         }
            public static cfg.battle.SelectCount unmarshal_cfg_battle_SelectCount(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.battle.SelectCount x;
                            switch(id) {
                            case 0: return null;
                            case 12359 : x = new cfg.battle.RepeatCount(os); break;case 15319 : x = new cfg.battle.SingleCount(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.map.EPathDir> unmarshal_list_cfg_map_EPathDir(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.map.EPathDir>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add((cfg.map.EPathDir)(os.ReadInt()));
                            }return x;
                         }
            public static cfg.shop.SellInfo unmarshal_cfg_shop_SellInfo(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.shop.SellInfo x;
                            switch(id) {
                            case 0: return null;
                            case 65230 : x = new cfg.shop.SellItem(os); break;case 5617 : x = new cfg.shop.SellCurrency(os); break;case 60652 : x = new cfg.shop.SellGift(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.battle.BattleAsset unmarshal_cfg_battle_BattleAsset(Perfect.Marshal.Octets os) {
                            return new cfg.battle.BattleAsset(os);
                         }
            public static cfg.map.MapPath unmarshal_cfg_map_MapPath(Perfect.Marshal.Octets os) {
                            return new cfg.map.MapPath(os);
                         }
            public static cfg.shop.CostWithCount unmarshal_cfg_shop_CostWithCount(Perfect.Marshal.Octets os) {
                            return new cfg.shop.CostWithCount(os);
                         }
            public static cfg.battle.SingleCount unmarshal_cfg_battle_SingleCount(Perfect.Marshal.Octets os) {
                            return new cfg.battle.SingleCount(os);
                         }
            public static System.Collections.Generic.List<cfg.battle.BattleRefresh> unmarshal_list_cfg_battle_BattleRefresh(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.battle.BattleRefresh>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_battle_BattleRefresh(os));
                            }return x;
                         }
            public static cfg.skill.BulletType unmarshal_cfg_skill_BulletType(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.skill.BulletType x;
                            switch(id) {
                            case 0: return null;
                            case 41809 : x = new cfg.skill.FlyBullet(os); break;case 4599 : x = new cfg.skill.ImmediateBullet(os); break;case 36088 : x = new cfg.skill.BeamBullet(os); break;case 35645 : x = new cfg.skill.PathBullet(os); break;case 64582 : x = new cfg.skill.TerrainBullet(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.condition.Or unmarshal_cfg_condition_Or(Perfect.Marshal.Octets os) {
                            return new cfg.condition.Or(os);
                         }
            public static cfg.common.And unmarshal_cfg_common_And(Perfect.Marshal.Octets os) {
                            return new cfg.common.And(os);
                         }
            public static cfg.battle.SelectBuffType3Trigger unmarshal_cfg_battle_SelectBuffType3Trigger(Perfect.Marshal.Octets os) {
                            var id = os.ReadInt();
                            cfg.battle.SelectBuffType3Trigger x;
                            switch(id) {
                            case 0: return null;
                            case 55368 : x = new cfg.battle.CastleHpDownto(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
                            return x;
                         }
            public static cfg.level.Chapter unmarshal_cfg_level_Chapter(Perfect.Marshal.Octets os) {
                            return new cfg.level.Chapter(os);
                         }
            public static cfg.localize.Language unmarshal_cfg_localize_Language(Perfect.Marshal.Octets os) {
                            return new cfg.localize.Language(os);
                         }
            public static System.Collections.Generic.List<cfg.function.Jump> unmarshal_list_cfg_function_Jump(Perfect.Marshal.Octets os) {
                            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
                            var x = new System.Collections.Generic.List<cfg.function.Jump>(n);
                            for(int i = 0 ; i < n ; i++) {
                            x.Add(cfg.Extensions.unmarshal_cfg_function_Jump(os));
                            }return x;
                         }
            public static cfg.shop.MoneyCost unmarshal_cfg_shop_MoneyCost(Perfect.Marshal.Octets os) {
                            return new cfg.shop.MoneyCost(os);
                         }


            public static void xml_marshal_cfg_battle_RandomBuff(cfg.battle.RandomBuff x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_Fire(cfg.skill.Fire x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_global_GInt64(cfg.global.GInt64 x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_user_UserTitle(cfg.user.UserTitle x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_item_ItemInfo(cfg.item.ItemInfo x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_Frozen(cfg.skill.Frozen x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_function_Jump(cfg.function.Jump x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_item_None(cfg.item.None x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_localize_TexSizeElement(cfg.localize.TexSizeElement x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_SellCurrency(cfg.shop.SellCurrency x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_map_MapOutDirFilter(cfg.map.MapOutDirFilter x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_summon_Summon(cfg.summon.Summon x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_castle_CastleSkill(cfg.castle.CastleSkill x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_Delay(cfg.skill.Delay x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_HitAnyOne(cfg.skill.HitAnyOne x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_error_Error(cfg.error.Error x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_BattleStartBuffContent(cfg.battle.BattleStartBuffContent x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_ImmediateBullet(cfg.skill.ImmediateBullet x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_sysbuff_BattleStartBuff(cfg.sysbuff.BattleStartBuff x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_KillExpAdd(cfg.battle.KillExpAdd x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_RefreshMonster(cfg.battle.RefreshMonster x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_ShopInfo(cfg.shop.ShopInfo x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_BuffConfig(cfg.skill.BuffConfig x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_ItemCost(cfg.shop.ItemCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_BulletConfig(cfg.skill.BulletConfig x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_BuffChangeContent(cfg.skill.BuffChangeContent x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_castle_CastleUpgradeUserTitleReward(cfg.castle.CastleUpgradeUserTitleReward x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_summon_SummonUpgrade(System.Collections.Generic.List<cfg.summon.SummonUpgrade> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_summon_SummonUpgrade(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_list_cfg_level_Chapter(System.Collections.Generic.List<cfg.level.Chapter> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_level_Chapter(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_skill_BuffDestroyType(cfg.skill.BuffDestroyType x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_AddBuff(cfg.skill.AddBuff x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_RandomBuffLibContent(cfg.battle.RandomBuffLibContent x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_HitImmediate(cfg.skill.HitImmediate x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_DailyGoods(cfg.shop.DailyGoods x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_StartSelectBuffOnce(cfg.battle.StartSelectBuffOnce x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_SingeTowerTarget(cfg.battle.SingeTowerTarget x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_castle_CastleUpgradeSysBuffReward(cfg.castle.CastleUpgradeSysBuffReward x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_GoodsInfo(cfg.shop.GoodsInfo x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_SelectBuffType(cfg.battle.SelectBuffType x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_localize_TexLocalizeElements(cfg.localize.TexLocalizeElements x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_EffectNum(cfg.skill.EffectNum x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_HpChange(cfg.skill.HpChange x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_tower_TowerUpgradeWithBuffInfo(cfg.tower.TowerUpgradeWithBuffInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_map_MapOutDirFilter(System.Collections.Generic.List<cfg.map.MapOutDirFilter> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_map_MapOutDirFilter(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_skill_ReleaseBuff(cfg.skill.ReleaseBuff x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_condition_None(cfg.condition.None x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_sound_Audio(cfg.sound.Audio x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_item_CastleSkillFragmentInfo(cfg.item.CastleSkillFragmentInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_BeforeDeadHaveState(cfg.skill.BeforeDeadHaveState x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_localize_Language(System.Collections.Generic.List<cfg.localize.Language> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_localize_Language(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_skill_HitFixTarget(cfg.skill.HitFixTarget x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_GlobalTarget(cfg.battle.GlobalTarget x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_TerrainBullet(cfg.skill.TerrainBullet x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_CostWithInterval(cfg.shop.CostWithInterval x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_map_MapGround(cfg.map.MapGround x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_HitDelay(cfg.skill.HitDelay x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_function_JumpBattleInfo(cfg.function.JumpBattleInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_CastleHpDownto(cfg.battle.CastleHpDownto x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_bonus_CopyBonus(cfg.bonus.CopyBonus x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_tower_TowerSlot(cfg.tower.TowerSlot x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_DailyRefresh(cfg.shop.DailyRefresh x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_SelectBuffType3(cfg.battle.SelectBuffType3 x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_XBigDecimal(cfg.common.XBigDecimal x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_SelectBuffType2(cfg.battle.SelectBuffType2 x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_SelectBuffType1(cfg.battle.SelectBuffType1 x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_BuffRemove(cfg.skill.BuffRemove x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_ShopRefreshInfo(cfg.shop.ShopRefreshInfo x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_sound_Sound(System.Collections.Generic.List<cfg.sound.Sound> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_sound_Sound(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_skill_BulletTrackConfig(cfg.skill.BulletTrackConfig x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_map_OutDirFilterAdd(cfg.map.OutDirFilterAdd x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_summon_SummonReward(System.Collections.Generic.List<cfg.summon.SummonReward> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_summon_SummonReward(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_tower_TowerUpgradeInfo(cfg.tower.TowerUpgradeInfo x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_map_mapEventShowWeight(System.Collections.Generic.List<cfg.map.mapEventShowWeight> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_map_mapEventShowWeight(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_battle_MapBuild(cfg.battle.MapBuild x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_asset_Asset(System.Collections.Generic.List<cfg.asset.Asset> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_asset_Asset(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_localize_TexPositionElement(cfg.localize.TexPositionElement x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_bonus_Item(cfg.bonus.Item x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_level_BattleLevel(System.Collections.Generic.List<cfg.level.BattleLevel> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_level_BattleLevel(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_battle_MoneyWaveAdd(cfg.battle.MoneyWaveAdd x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_EffectUnlimit(cfg.skill.EffectUnlimit x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_map_int_cfg_tower_TowerUpgradeInfo(System.Collections.Generic.Dictionary<int,cfg.tower.TowerUpgradeInfo> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            ele.WriteStartElement("key");
                            ele.WriteInt(_e.Key);
                            ele.WriteEndElement();
                            ele.WriteStartElement("value");
                            cfg.Extensions.xml_marshal_cfg_tower_TowerUpgradeInfo(_e.Value,ele);
                            ele.WriteEndElement();
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_castle_CastleUpgradeReward(cfg.castle.CastleUpgradeReward x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_map_mapEventShowWeight(cfg.map.mapEventShowWeight x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_attribute_Attribute(System.Collections.Generic.List<cfg.attribute.Attribute> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_attribute_Attribute(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_item_Item(cfg.item.Item x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_skill_BulletTrackConfig(System.Collections.Generic.List<cfg.skill.BulletTrackConfig> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_skill_BulletTrackConfig(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_list_cfg_level_ChapterBox(System.Collections.Generic.List<cfg.level.ChapterBox> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_level_ChapterBox(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_sound_Sound(cfg.sound.Sound x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_hero_Hero(cfg.hero.Hero x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_Vector2Int(cfg.Vector2Int x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_battle_MapLevel(System.Collections.Generic.List<cfg.battle.MapLevel> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_battle_MapLevel(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_shop_EveryDayFreeGoods(cfg.shop.EveryDayFreeGoods x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_attribute_AttributeLongNumber(cfg.attribute.AttributeLongNumber x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_XFloat(cfg.common.XFloat x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_summon_SummonReward(cfg.summon.SummonReward x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_asset_Asset(cfg.asset.Asset x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_asset_AssetInfo(cfg.asset.AssetInfo x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_function_AdGetCurrencyInfo(cfg.function.AdGetCurrencyInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_StackNum(cfg.skill.StackNum x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_Dizz(cfg.skill.Dizz x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_attribute_AttributeInfo(System.Collections.Generic.List<cfg.attribute.AttributeInfo> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_attribute_AttributeInfo(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_battle_HeroTarget(cfg.battle.HeroTarget x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_skill_BulletConfig(System.Collections.Generic.List<cfg.skill.BulletConfig> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_skill_BulletConfig(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_list_cfg_item_Quality(System.Collections.Generic.List<cfg.item.Quality> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_item_Quality(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_list_cfg_battle_RefreshWave(System.Collections.Generic.List<cfg.battle.RefreshWave> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_battle_RefreshWave(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_shop_LimitByUser(cfg.shop.LimitByUser x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_global_GBool(cfg.global.GBool x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_Shop(cfg.shop.Shop x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_HitInterval(cfg.skill.HitInterval x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_bonus_MultiBonus(cfg.bonus.MultiBonus x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_IntervalCheck(cfg.skill.IntervalCheck x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_InTerrain(cfg.skill.InTerrain x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_function_JumpShopInfo(cfg.function.JumpShopInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_TerrainAddBuff(cfg.skill.TerrainAddBuff x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_map_MapPath(System.Collections.Generic.List<cfg.map.MapPath> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_map_MapPath(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_bonus_RandomBonus(cfg.bonus.RandomBonus x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_ImmediateTrigger(cfg.skill.ImmediateTrigger x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_XLong(cfg.common.XLong x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_ReleaseSkill(cfg.skill.ReleaseSkill x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_BeforeTakeBuffEffect(cfg.skill.BeforeTakeBuffEffect x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_sysbuff_CastleAddAtkSlotSysBuff(cfg.sysbuff.CastleAddAtkSlotSysBuff x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_bonus_WeightRandomBonus(cfg.bonus.WeightRandomBonus x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_global_GInt32(cfg.global.GInt32 x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_monster_Monster(cfg.monster.Monster x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_BuildingTower(cfg.battle.BuildingTower x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_AfterTime(cfg.skill.AfterTime x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_Vector2(cfg.Vector2 x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_attribute_AttributeLongNumber(System.Collections.Generic.List<cfg.attribute.AttributeLongNumber> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_attribute_AttributeLongNumber(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_common_AdCost(cfg.common.AdCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_RandomBuffLib(cfg.battle.RandomBuffLib x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_NormalGoods(cfg.shop.NormalGoods x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_StateDisappear(cfg.skill.StateDisappear x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_Vector3(cfg.Vector3 x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_BuffStatcking(cfg.skill.BuffStatcking x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_CostType(cfg.shop.CostType x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_global_GlobalInfo(cfg.global.GlobalInfo x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_condition_CastleLevel(cfg.condition.CastleLevel x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_condition_ChapterPass(cfg.condition.ChapterPass x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_global_Global(System.Collections.Generic.List<cfg.global.Global> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_global_Global(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_common_MoneyCost(cfg.common.MoneyCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_tower_TowerSlot(System.Collections.Generic.List<cfg.tower.TowerSlot> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_tower_TowerSlot(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_skill_FlyBullet(cfg.skill.FlyBullet x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_ItemCost(cfg.common.ItemCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_tower_TowerUpgradeNoBuffInfo(cfg.tower.TowerUpgradeNoBuffInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_RefreshBuffFree(cfg.battle.RefreshBuffFree x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_BatchCost(cfg.shop.BatchCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_skill_BuffConfig(System.Collections.Generic.List<cfg.skill.BuffConfig> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_skill_BuffConfig(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_list_cfg_skill_BuffChangeContent(System.Collections.Generic.List<cfg.skill.BuffChangeContent> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_skill_BuffChangeContent(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_shop_EveryDay(cfg.shop.EveryDay x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_Interval(cfg.skill.Interval x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_sysbuff_SysBuffInfo(cfg.sysbuff.SysBuffInfo x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_asset_Texture(cfg.asset.Texture x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_map_LevelUp(System.Collections.Generic.List<cfg.map.LevelUp> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_map_LevelUp(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_skill_DamageAdjust(cfg.skill.DamageAdjust x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_function_JumpInfo(cfg.function.JumpInfo x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_battle_MapBuild(System.Collections.Generic.List<cfg.battle.MapBuild> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_battle_MapBuild(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_bonus_RefBonus(cfg.bonus.RefBonus x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_RepeatCount(cfg.battle.RepeatCount x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_InFixTime(cfg.skill.InFixTime x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_OtherControll(cfg.skill.OtherControll x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_TotalTowerTarget(cfg.battle.TotalTowerTarget x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_monster_Monster(System.Collections.Generic.List<cfg.monster.Monster> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_monster_Monster(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_bonus_Currency(cfg.bonus.Currency x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_sound_SoundEffect(cfg.sound.SoundEffect x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_shop_Shop(System.Collections.Generic.List<cfg.shop.Shop> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_shop_Shop(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_shop_LimitBuyType(cfg.shop.LimitBuyType x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_level_ChapterBox(cfg.level.ChapterBox x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_castle_CastleUpgradeNoReward(cfg.castle.CastleUpgradeNoReward x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_shop_DailyDiscountWeight(System.Collections.Generic.List<cfg.shop.DailyDiscountWeight> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_shop_DailyDiscountWeight(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_common_Cost(cfg.common.Cost x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_bonus_ItemId(cfg.bonus.ItemId x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_HitSpTypeMonster(cfg.skill.HitSpTypeMonster x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_summon_SummonUpgrade(cfg.summon.SummonUpgrade x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_shop_GoodsInfo(System.Collections.Generic.List<cfg.shop.GoodsInfo> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_shop_GoodsInfo(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_shop_NotLimit(cfg.shop.NotLimit x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_battle_RandomBuff(System.Collections.Generic.List<cfg.battle.RandomBuff> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_battle_RandomBuff(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_tower_Tower(cfg.tower.Tower x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_battle_SelectBuff(System.Collections.Generic.List<cfg.battle.SelectBuff> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_battle_SelectBuff(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_battle_RefreshWave(cfg.battle.RefreshWave x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_XNumber(cfg.common.XNumber x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_bonus_Item(System.Collections.Generic.List<cfg.bonus.Item> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_bonus_Item(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_list_cfg_error_Error(System.Collections.Generic.List<cfg.error.Error> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_error_Error(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_list_cfg_battle_RandomBuffLib(System.Collections.Generic.List<cfg.battle.RandomBuffLib> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_battle_RandomBuffLib(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_common_CurrencyGlobal(cfg.common.CurrencyGlobal x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_KillEnergyAdd(cfg.battle.KillEnergyAdd x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_condition_OwnItem(cfg.condition.OwnItem x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_SplitBullet(cfg.skill.SplitBullet x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_condition_And(cfg.condition.And x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_shop_DailyGoodsRefresh(System.Collections.Generic.List<cfg.shop.DailyGoodsRefresh> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_shop_DailyGoodsRefresh(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_list_int(System.Collections.Generic.List<int> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            ele.WriteInt(_e);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_castle_CastleSkillUpgradeInfo(cfg.castle.CastleSkillUpgradeInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_item_Quality(cfg.item.Quality x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_HitTarget(cfg.skill.HitTarget x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_sysbuff_SysBuff(System.Collections.Generic.List<cfg.sysbuff.SysBuff> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_sysbuff_SysBuff(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_shop_DayLimit(cfg.shop.DayLimit x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_shop_DailyGoods(System.Collections.Generic.List<cfg.shop.DailyGoods> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_shop_DailyGoods(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_shop_DailyGoodsRefresh(cfg.shop.DailyGoodsRefresh x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_item_Item(System.Collections.Generic.List<cfg.item.Item> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_item_Item(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_skill_Immediate(cfg.skill.Immediate x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_tower_TowerUpgrade(System.Collections.Generic.List<cfg.tower.TowerUpgrade> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_tower_TowerUpgrade(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_tower_LockSlot(cfg.tower.LockSlot x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_WeeklyRefresh(cfg.shop.WeeklyRefresh x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_NoramlRelease(cfg.skill.NoramlRelease x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_tower_Tower(System.Collections.Generic.List<cfg.tower.Tower> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_tower_Tower(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_shop_Free(cfg.shop.Free x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_skill_SkillReleaseConfig(System.Collections.Generic.List<cfg.skill.SkillReleaseConfig> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_skill_SkillReleaseConfig(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_skill_BuffChange(cfg.skill.BuffChange x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_CreateBulletDataFinish(cfg.skill.CreateBulletDataFinish x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_localize_TexLocalizeElement(System.Collections.Generic.List<cfg.localize.TexLocalizeElement> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_localize_TexLocalizeElement(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_localize_TexAssetElement(cfg.localize.TexAssetElement x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_AddQualityAboveBuffWeight(cfg.battle.AddQualityAboveBuffWeight x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_BulletDestroyType(cfg.skill.BulletDestroyType x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_DailyDiscountWeight(cfg.shop.DailyDiscountWeight x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_sysbuff_TowerAttrSysBuff(cfg.sysbuff.TowerAttrSysBuff x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_global_Global(cfg.global.Global x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_shop_CostType(System.Collections.Generic.List<cfg.shop.CostType> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_shop_CostType(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_map_int_cfg_castle_CastleSkillUpgradeInfo(System.Collections.Generic.Dictionary<int,cfg.castle.CastleSkillUpgradeInfo> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            ele.WriteStartElement("key");
                            ele.WriteInt(_e.Key);
                            ele.WriteEndElement();
                            ele.WriteStartElement("value");
                            cfg.Extensions.xml_marshal_cfg_castle_CastleSkillUpgradeInfo(_e.Value,ele);
                            ele.WriteEndElement();
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_castle_Castle(cfg.castle.Castle x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_sysbuff_SysBuff(cfg.sysbuff.SysBuff x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_AfterTakeBuffEffect(cfg.skill.AfterTakeBuffEffect x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_DailyShopInfo(cfg.shop.DailyShopInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_StartBuff(cfg.battle.StartBuff x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_bonus_Items(cfg.bonus.Items x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_condition_Condition(System.Collections.Generic.List<cfg.condition.Condition> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_condition_Condition(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_list_cfg_shop_SellInfo(System.Collections.Generic.List<cfg.shop.SellInfo> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_shop_SellInfo(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_localize_TexLocalizeElement(cfg.localize.TexLocalizeElement x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_SkillReleaseConfig(cfg.skill.SkillReleaseConfig x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_level_BattleLevel(cfg.level.BattleLevel x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_MapLevel(cfg.battle.MapLevel x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_bonus_RandomTowerFragmentQuality(cfg.bonus.RandomTowerFragmentQuality x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_bonus_WeightBonus(System.Collections.Generic.List<cfg.bonus.WeightBonus> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_bonus_WeightBonus(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_global_GString(cfg.global.GString x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_castle_CastleUpgradeBonusReward(cfg.castle.CastleUpgradeBonusReward x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_map_cfg_localize_ELanguageType_cfg_localize_TexLocalizeElement(System.Collections.Generic.Dictionary<cfg.localize.ELanguageType,cfg.localize.TexLocalizeElement> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            ele.WriteStartElement("key");
                            ele.WriteEnum(_e.Key);
                            ele.WriteEndElement();
                            ele.WriteStartElement("value");
                            cfg.Extensions.xml_marshal_cfg_localize_TexLocalizeElement(_e.Value,ele);
                            ele.WriteEndElement();
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_skill_PathBullet(cfg.skill.PathBullet x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_BulletEffectType(cfg.skill.BulletEffectType x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_battle_StartBuff(System.Collections.Generic.List<cfg.battle.StartBuff> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_battle_StartBuff(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_skill_BulletChange(cfg.skill.BulletChange x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_castle_CastleAttrUpInfo(System.Collections.Generic.List<cfg.castle.CastleAttrUpInfo> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_castle_CastleAttrUpInfo(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_list_cfg_localize_TextureLanguage(System.Collections.Generic.List<cfg.localize.TextureLanguage> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_localize_TextureLanguage(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_tower_DefaultTowerSlot(cfg.tower.DefaultTowerSlot x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_AttributeChange(cfg.skill.AttributeChange x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_battle_RefreshMonster(System.Collections.Generic.List<cfg.battle.RefreshMonster> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_battle_RefreshMonster(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_battle_SelectBuff(cfg.battle.SelectBuff x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_SellItem(cfg.shop.SellItem x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_BuffTriggerType(cfg.skill.BuffTriggerType x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_HitStateTarget(cfg.skill.HitStateTarget x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_condition_Currency(cfg.condition.Currency x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_condition_Condition(cfg.condition.Condition x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_bonus_Bonus(System.Collections.Generic.List<cfg.bonus.Bonus> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_bonus_Bonus(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_battle_EffectTarget(cfg.battle.EffectTarget x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_Forever(cfg.skill.Forever x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_Currency(cfg.common.Currency x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_CurrencyCost(cfg.common.CurrencyCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_StackReset(cfg.skill.StackReset x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_bonus_BonusData(System.Collections.Generic.List<cfg.bonus.BonusData> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_bonus_BonusData(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_bonus_Empty(cfg.bonus.Empty x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_attribute_AttributeInfo(cfg.attribute.AttributeInfo x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_castle_CastleUpgrade(System.Collections.Generic.List<cfg.castle.CastleUpgrade> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_castle_CastleUpgrade(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_common_XInt(cfg.common.XInt x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_item_TowerFragmentInfo(cfg.item.TowerFragmentInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_SellGift(cfg.shop.SellGift x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_BeamBullet(cfg.skill.BeamBullet x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_StackNone(cfg.skill.StackNone x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_AttackDamage(cfg.skill.AttackDamage x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_BuildingRoad(cfg.battle.BuildingRoad x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_user_UserTitle(System.Collections.Generic.List<cfg.user.UserTitle> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_user_UserTitle(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_condition_BuyMonthlyCard(cfg.condition.BuyMonthlyCard x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_map_cfg_summon_ESummonType_cfg_bonus_Bonus(System.Collections.Generic.Dictionary<cfg.summon.ESummonType,cfg.bonus.Bonus> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            ele.WriteStartElement("key");
                            ele.WriteEnum(_e.Key);
                            ele.WriteEndElement();
                            ele.WriteStartElement("value");
                            cfg.Extensions.xml_marshal_cfg_bonus_Bonus(_e.Value,ele);
                            ele.WriteEndElement();
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_tower_Empty(cfg.tower.Empty x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_ReleaseNumCritical(cfg.skill.ReleaseNumCritical x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_sound_Music(cfg.sound.Music x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_map_int_cfg_castle_AttrUpgradeInfo(System.Collections.Generic.Dictionary<int,cfg.castle.AttrUpgradeInfo> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            ele.WriteStartElement("key");
                            ele.WriteInt(_e.Key);
                            ele.WriteEndElement();
                            ele.WriteStartElement("value");
                            cfg.Extensions.xml_marshal_cfg_castle_AttrUpgradeInfo(_e.Value,ele);
                            ele.WriteEndElement();
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_skill_ReleaseBullet(cfg.skill.ReleaseBullet x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_castle_CastleSkill(System.Collections.Generic.List<cfg.castle.CastleSkill> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_castle_CastleSkill(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_shop_MultiCost(cfg.shop.MultiCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_map_OutDirFilterAdd(System.Collections.Generic.List<cfg.map.OutDirFilterAdd> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_map_OutDirFilterAdd(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_castle_CastleAttrUpInfo(cfg.castle.CastleAttrUpInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_map_mapEvent(System.Collections.Generic.List<cfg.map.mapEvent> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_map_mapEvent(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_skill_ReleasePlusBullet(cfg.skill.ReleasePlusBullet x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_EffectOnce(cfg.skill.EffectOnce x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_global_GFloat(cfg.global.GFloat x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_CastleTarget(cfg.battle.CastleTarget x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_item_SummonInfo(cfg.item.SummonInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_AdCost(cfg.shop.AdCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_localize_TextureLanguage(cfg.localize.TextureLanguage x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_BuildingType(cfg.battle.BuildingType x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_SkillPropertyChange(cfg.skill.SkillPropertyChange x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_ReleaseFlashBullet(cfg.skill.ReleaseFlashBullet x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_tower_SlotInfo(cfg.tower.SlotInfo x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_tower_TowerUpgrade(cfg.tower.TowerUpgrade x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_summon_Summon(System.Collections.Generic.List<cfg.summon.Summon> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_summon_Summon(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_battle_BattleRefresh(cfg.battle.BattleRefresh x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_map_MapGround(System.Collections.Generic.List<cfg.map.MapGround> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_map_MapGround(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_shop_EveryWeek(cfg.shop.EveryWeek x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_map_mapEvent(cfg.map.mapEvent x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_None(cfg.common.None x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_NromalShopInfo(cfg.shop.NromalShopInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_bonus_Bonus(cfg.bonus.Bonus x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_common_Currency(System.Collections.Generic.List<cfg.common.Currency> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_common_Currency(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_battle_EnemyTarget(cfg.battle.EnemyTarget x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_attribute_Attribute(cfg.attribute.Attribute x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_castle_AttrUpgradeInfo(cfg.castle.AttrUpgradeInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_attribute_None(cfg.attribute.None x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_castle_CastleUpgrade(cfg.castle.CastleUpgrade x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_BuffEffectContent(cfg.skill.BuffEffectContent x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_common_Cost(System.Collections.Generic.List<cfg.common.Cost> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_common_Cost(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_list_cfg_hero_Hero(System.Collections.Generic.List<cfg.hero.Hero> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_hero_Hero(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_common_Or(cfg.common.Or x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_localize_TexScaleElement(cfg.localize.TexScaleElement x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_bonus_BonusData(cfg.bonus.BonusData x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_battle_BattleAsset(System.Collections.Generic.List<cfg.battle.BattleAsset> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_battle_BattleAsset(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_bonus_WeightBonus(cfg.bonus.WeightBonus x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_AOEPlusDamage(cfg.skill.AOEPlusDamage x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_HitBack(cfg.skill.HitBack x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_BattleIncomeAdd(cfg.battle.BattleIncomeAdd x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_SpDamageTypeTowerTarget(cfg.battle.SpDamageTypeTowerTarget x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_battle_RandomBuffLibContent(System.Collections.Generic.List<cfg.battle.RandomBuffLibContent> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_battle_RandomBuffLibContent(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_shop_NotRefresh(cfg.shop.NotRefresh x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_attribute_AttributeNumber(cfg.attribute.AttributeNumber x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_SkillReleaseType(cfg.skill.SkillReleaseType x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_EveryMonth(cfg.shop.EveryMonth x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_CurrencyCost(cfg.shop.CurrencyCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_BuffEffectType(cfg.skill.BuffEffectType x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_bonus_RepeatBonus(cfg.bonus.RepeatBonus x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_map_LevelUp(cfg.map.LevelUp x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_condition_Item(cfg.condition.Item x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_attribute_And(cfg.attribute.And x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_item_GiftInfo(cfg.item.GiftInfo x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_skill_AfterExcute(cfg.skill.AfterExcute x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_asset_Sprite(cfg.asset.Sprite x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_sysbuff_CastleAttrSysBuff(cfg.sysbuff.CastleAttrSysBuff x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_SelectCount(cfg.battle.SelectCount x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_map_EPathDir(System.Collections.Generic.List<cfg.map.EPathDir> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            ele.WriteEnum(_e);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_shop_SellInfo(cfg.shop.SellInfo x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_BattleAsset(cfg.battle.BattleAsset x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_map_MapPath(cfg.map.MapPath x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_shop_CostWithCount(cfg.shop.CostWithCount x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_SingleCount(cfg.battle.SingleCount x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_battle_BattleRefresh(System.Collections.Generic.List<cfg.battle.BattleRefresh> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_battle_BattleRefresh(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_skill_BulletType(cfg.skill.BulletType x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_condition_Or(cfg.condition.Or x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_common_And(cfg.common.And x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_battle_SelectBuffType3Trigger(cfg.battle.SelectBuffType3Trigger x, XmlWriter ele) {
                            if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_level_Chapter(cfg.level.Chapter x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_cfg_localize_Language(cfg.localize.Language x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }
            public static void xml_marshal_list_cfg_function_Jump(System.Collections.Generic.List<cfg.function.Jump> x, XmlWriter ele) {
                            foreach(var _e in x) {
                            ele.WriteStartElement("item");
                            cfg.Extensions.xml_marshal_cfg_function_Jump(_e,ele);
                            ele.WriteEndElement();
                            }
                         }
            public static void xml_marshal_cfg_shop_MoneyCost(cfg.shop.MoneyCost x, XmlWriter ele) {
                            x.MarshalXml(ele);
                         }

            public static cfg.battle.RandomBuff xml_unmarshal_cfg_battle_RandomBuff(XmlElement ele) {
                            var x = new cfg.battle.RandomBuff(ele);
                            return x;
                         }
            public static cfg.skill.Fire xml_unmarshal_cfg_skill_Fire(XmlElement ele) {
                            var x = new cfg.skill.Fire(ele);
                            return x;
                         }
            public static cfg.global.GInt64 xml_unmarshal_cfg_global_GInt64(XmlElement ele) {
                            var x = new cfg.global.GInt64(ele);
                            return x;
                         }
            public static cfg.user.UserTitle xml_unmarshal_cfg_user_UserTitle(XmlElement ele) {
                            var x = new cfg.user.UserTitle(ele);
                            return x;
                         }
            public static cfg.item.ItemInfo xml_unmarshal_cfg_item_ItemInfo(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.item.ItemInfo x;
                            switch(type) {
                            case "null": return null;
                            case "None" : x = new cfg.item.None(ele); break;
                            case "TowerFragmentInfo" : x = new cfg.item.TowerFragmentInfo(ele); break;
                            case "GiftInfo" : x = new cfg.item.GiftInfo(ele); break;
                            case "CastleSkillFragmentInfo" : x = new cfg.item.CastleSkillFragmentInfo(ele); break;
                            case "SummonInfo" : x = new cfg.item.SummonInfo(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.skill.Frozen xml_unmarshal_cfg_skill_Frozen(XmlElement ele) {
                            var x = new cfg.skill.Frozen(ele);
                            return x;
                         }
            public static cfg.function.Jump xml_unmarshal_cfg_function_Jump(XmlElement ele) {
                            var x = new cfg.function.Jump(ele);
                            return x;
                         }
            public static cfg.item.None xml_unmarshal_cfg_item_None(XmlElement ele) {
                            var x = new cfg.item.None(ele);
                            return x;
                         }
            public static cfg.localize.TexSizeElement xml_unmarshal_cfg_localize_TexSizeElement(XmlElement ele) {
                            var x = new cfg.localize.TexSizeElement(ele);
                            return x;
                         }
            public static cfg.shop.SellCurrency xml_unmarshal_cfg_shop_SellCurrency(XmlElement ele) {
                            var x = new cfg.shop.SellCurrency(ele);
                            return x;
                         }
            public static cfg.map.MapOutDirFilter xml_unmarshal_cfg_map_MapOutDirFilter(XmlElement ele) {
                            var x = new cfg.map.MapOutDirFilter(ele);
                            return x;
                         }
            public static cfg.summon.Summon xml_unmarshal_cfg_summon_Summon(XmlElement ele) {
                            var x = new cfg.summon.Summon(ele);
                            return x;
                         }
            public static cfg.castle.CastleSkill xml_unmarshal_cfg_castle_CastleSkill(XmlElement ele) {
                            var x = new cfg.castle.CastleSkill(ele);
                            return x;
                         }
            public static cfg.skill.Delay xml_unmarshal_cfg_skill_Delay(XmlElement ele) {
                            var x = new cfg.skill.Delay(ele);
                            return x;
                         }
            public static cfg.skill.HitAnyOne xml_unmarshal_cfg_skill_HitAnyOne(XmlElement ele) {
                            var x = new cfg.skill.HitAnyOne(ele);
                            return x;
                         }
            public static cfg.error.Error xml_unmarshal_cfg_error_Error(XmlElement ele) {
                            var x = new cfg.error.Error(ele);
                            return x;
                         }
            public static cfg.battle.BattleStartBuffContent xml_unmarshal_cfg_battle_BattleStartBuffContent(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.battle.BattleStartBuffContent x;
                            switch(type) {
                            case "null": return null;
                            case "StartSelectBuffOnce" : x = new cfg.battle.StartSelectBuffOnce(ele); break;
                            case "RefreshBuffFree" : x = new cfg.battle.RefreshBuffFree(ele); break;
                            case "BattleIncomeAdd" : x = new cfg.battle.BattleIncomeAdd(ele); break;
                            case "AddQualityAboveBuffWeight" : x = new cfg.battle.AddQualityAboveBuffWeight(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.skill.ImmediateBullet xml_unmarshal_cfg_skill_ImmediateBullet(XmlElement ele) {
                            var x = new cfg.skill.ImmediateBullet(ele);
                            return x;
                         }
            public static cfg.sysbuff.BattleStartBuff xml_unmarshal_cfg_sysbuff_BattleStartBuff(XmlElement ele) {
                            var x = new cfg.sysbuff.BattleStartBuff(ele);
                            return x;
                         }
            public static cfg.battle.KillExpAdd xml_unmarshal_cfg_battle_KillExpAdd(XmlElement ele) {
                            var x = new cfg.battle.KillExpAdd(ele);
                            return x;
                         }
            public static cfg.battle.RefreshMonster xml_unmarshal_cfg_battle_RefreshMonster(XmlElement ele) {
                            var x = new cfg.battle.RefreshMonster(ele);
                            return x;
                         }
            public static cfg.shop.ShopInfo xml_unmarshal_cfg_shop_ShopInfo(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.shop.ShopInfo x;
                            switch(type) {
                            case "null": return null;
                            case "NromalShopInfo" : x = new cfg.shop.NromalShopInfo(ele); break;
                            case "DailyShopInfo" : x = new cfg.shop.DailyShopInfo(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.skill.BuffConfig xml_unmarshal_cfg_skill_BuffConfig(XmlElement ele) {
                            var x = new cfg.skill.BuffConfig(ele);
                            return x;
                         }
            public static cfg.shop.ItemCost xml_unmarshal_cfg_shop_ItemCost(XmlElement ele) {
                            var x = new cfg.shop.ItemCost(ele);
                            return x;
                         }
            public static cfg.skill.BulletConfig xml_unmarshal_cfg_skill_BulletConfig(XmlElement ele) {
                            var x = new cfg.skill.BulletConfig(ele);
                            return x;
                         }
            public static cfg.skill.BuffChangeContent xml_unmarshal_cfg_skill_BuffChangeContent(XmlElement ele) {
                            var x = new cfg.skill.BuffChangeContent(ele);
                            return x;
                         }
            public static cfg.castle.CastleUpgradeUserTitleReward xml_unmarshal_cfg_castle_CastleUpgradeUserTitleReward(XmlElement ele) {
                            var x = new cfg.castle.CastleUpgradeUserTitleReward(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.summon.SummonUpgrade> xml_unmarshal_list_cfg_summon_SummonUpgrade(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.summon.SummonUpgrade>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_summon_SummonUpgrade(c));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.level.Chapter> xml_unmarshal_list_cfg_level_Chapter(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.level.Chapter>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_level_Chapter(c));
                            }return x;
                         }
            public static cfg.skill.BuffDestroyType xml_unmarshal_cfg_skill_BuffDestroyType(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.skill.BuffDestroyType x;
                            switch(type) {
                            case "null": return null;
                            case "Forever" : x = new cfg.skill.Forever(ele); break;
                            case "AfterExcute" : x = new cfg.skill.AfterExcute(ele); break;
                            case "InFixTime" : x = new cfg.skill.InFixTime(ele); break;
                            case "StateDisappear" : x = new cfg.skill.StateDisappear(ele); break;
                            case "BuffRemove" : x = new cfg.skill.BuffRemove(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.skill.AddBuff xml_unmarshal_cfg_skill_AddBuff(XmlElement ele) {
                            var x = new cfg.skill.AddBuff(ele);
                            return x;
                         }
            public static cfg.battle.RandomBuffLibContent xml_unmarshal_cfg_battle_RandomBuffLibContent(XmlElement ele) {
                            var x = new cfg.battle.RandomBuffLibContent(ele);
                            return x;
                         }
            public static cfg.skill.HitImmediate xml_unmarshal_cfg_skill_HitImmediate(XmlElement ele) {
                            var x = new cfg.skill.HitImmediate(ele);
                            return x;
                         }
            public static cfg.shop.DailyGoods xml_unmarshal_cfg_shop_DailyGoods(XmlElement ele) {
                            var x = new cfg.shop.DailyGoods(ele);
                            return x;
                         }
            public static cfg.battle.StartSelectBuffOnce xml_unmarshal_cfg_battle_StartSelectBuffOnce(XmlElement ele) {
                            var x = new cfg.battle.StartSelectBuffOnce(ele);
                            return x;
                         }
            public static cfg.battle.SingeTowerTarget xml_unmarshal_cfg_battle_SingeTowerTarget(XmlElement ele) {
                            var x = new cfg.battle.SingeTowerTarget(ele);
                            return x;
                         }
            public static cfg.castle.CastleUpgradeSysBuffReward xml_unmarshal_cfg_castle_CastleUpgradeSysBuffReward(XmlElement ele) {
                            var x = new cfg.castle.CastleUpgradeSysBuffReward(ele);
                            return x;
                         }
            public static cfg.shop.GoodsInfo xml_unmarshal_cfg_shop_GoodsInfo(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.shop.GoodsInfo x;
                            switch(type) {
                            case "null": return null;
                            case "NormalGoods" : x = new cfg.shop.NormalGoods(ele); break;
                            case "EveryDayFreeGoods" : x = new cfg.shop.EveryDayFreeGoods(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.battle.SelectBuffType xml_unmarshal_cfg_battle_SelectBuffType(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.battle.SelectBuffType x;
                            switch(type) {
                            case "null": return null;
                            case "SelectBuffType1" : x = new cfg.battle.SelectBuffType1(ele); break;
                            case "SelectBuffType2" : x = new cfg.battle.SelectBuffType2(ele); break;
                            case "SelectBuffType3" : x = new cfg.battle.SelectBuffType3(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.localize.TexLocalizeElements xml_unmarshal_cfg_localize_TexLocalizeElements(XmlElement ele) {
                            var x = new cfg.localize.TexLocalizeElements(ele);
                            return x;
                         }
            public static cfg.skill.EffectNum xml_unmarshal_cfg_skill_EffectNum(XmlElement ele) {
                            var x = new cfg.skill.EffectNum(ele);
                            return x;
                         }
            public static cfg.skill.HpChange xml_unmarshal_cfg_skill_HpChange(XmlElement ele) {
                            var x = new cfg.skill.HpChange(ele);
                            return x;
                         }
            public static cfg.tower.TowerUpgradeWithBuffInfo xml_unmarshal_cfg_tower_TowerUpgradeWithBuffInfo(XmlElement ele) {
                            var x = new cfg.tower.TowerUpgradeWithBuffInfo(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.map.MapOutDirFilter> xml_unmarshal_list_cfg_map_MapOutDirFilter(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.map.MapOutDirFilter>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_map_MapOutDirFilter(c));
                            }return x;
                         }
            public static cfg.skill.ReleaseBuff xml_unmarshal_cfg_skill_ReleaseBuff(XmlElement ele) {
                            var x = new cfg.skill.ReleaseBuff(ele);
                            return x;
                         }
            public static cfg.condition.None xml_unmarshal_cfg_condition_None(XmlElement ele) {
                            var x = new cfg.condition.None(ele);
                            return x;
                         }
            public static cfg.sound.Audio xml_unmarshal_cfg_sound_Audio(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.sound.Audio x;
                            switch(type) {
                            case "null": return null;
                            case "SoundEffect" : x = new cfg.sound.SoundEffect(ele); break;
                            case "Music" : x = new cfg.sound.Music(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.item.CastleSkillFragmentInfo xml_unmarshal_cfg_item_CastleSkillFragmentInfo(XmlElement ele) {
                            var x = new cfg.item.CastleSkillFragmentInfo(ele);
                            return x;
                         }
            public static cfg.skill.BeforeDeadHaveState xml_unmarshal_cfg_skill_BeforeDeadHaveState(XmlElement ele) {
                            var x = new cfg.skill.BeforeDeadHaveState(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.localize.Language> xml_unmarshal_list_cfg_localize_Language(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.localize.Language>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_localize_Language(c));
                            }return x;
                         }
            public static cfg.skill.HitFixTarget xml_unmarshal_cfg_skill_HitFixTarget(XmlElement ele) {
                            var x = new cfg.skill.HitFixTarget(ele);
                            return x;
                         }
            public static cfg.battle.GlobalTarget xml_unmarshal_cfg_battle_GlobalTarget(XmlElement ele) {
                            var x = new cfg.battle.GlobalTarget(ele);
                            return x;
                         }
            public static cfg.skill.TerrainBullet xml_unmarshal_cfg_skill_TerrainBullet(XmlElement ele) {
                            var x = new cfg.skill.TerrainBullet(ele);
                            return x;
                         }
            public static cfg.shop.CostWithInterval xml_unmarshal_cfg_shop_CostWithInterval(XmlElement ele) {
                            var x = new cfg.shop.CostWithInterval(ele);
                            return x;
                         }
            public static cfg.map.MapGround xml_unmarshal_cfg_map_MapGround(XmlElement ele) {
                            var x = new cfg.map.MapGround(ele);
                            return x;
                         }
            public static cfg.skill.HitDelay xml_unmarshal_cfg_skill_HitDelay(XmlElement ele) {
                            var x = new cfg.skill.HitDelay(ele);
                            return x;
                         }
            public static cfg.function.JumpBattleInfo xml_unmarshal_cfg_function_JumpBattleInfo(XmlElement ele) {
                            var x = new cfg.function.JumpBattleInfo(ele);
                            return x;
                         }
            public static cfg.battle.CastleHpDownto xml_unmarshal_cfg_battle_CastleHpDownto(XmlElement ele) {
                            var x = new cfg.battle.CastleHpDownto(ele);
                            return x;
                         }
            public static cfg.bonus.CopyBonus xml_unmarshal_cfg_bonus_CopyBonus(XmlElement ele) {
                            var x = new cfg.bonus.CopyBonus(ele);
                            return x;
                         }
            public static cfg.tower.TowerSlot xml_unmarshal_cfg_tower_TowerSlot(XmlElement ele) {
                            var x = new cfg.tower.TowerSlot(ele);
                            return x;
                         }
            public static cfg.shop.DailyRefresh xml_unmarshal_cfg_shop_DailyRefresh(XmlElement ele) {
                            var x = new cfg.shop.DailyRefresh(ele);
                            return x;
                         }
            public static cfg.battle.SelectBuffType3 xml_unmarshal_cfg_battle_SelectBuffType3(XmlElement ele) {
                            var x = new cfg.battle.SelectBuffType3(ele);
                            return x;
                         }
            public static cfg.common.XBigDecimal xml_unmarshal_cfg_common_XBigDecimal(XmlElement ele) {
                            var x = new cfg.common.XBigDecimal(ele);
                            return x;
                         }
            public static cfg.battle.SelectBuffType2 xml_unmarshal_cfg_battle_SelectBuffType2(XmlElement ele) {
                            var x = new cfg.battle.SelectBuffType2(ele);
                            return x;
                         }
            public static cfg.battle.SelectBuffType1 xml_unmarshal_cfg_battle_SelectBuffType1(XmlElement ele) {
                            var x = new cfg.battle.SelectBuffType1(ele);
                            return x;
                         }
            public static cfg.skill.BuffRemove xml_unmarshal_cfg_skill_BuffRemove(XmlElement ele) {
                            var x = new cfg.skill.BuffRemove(ele);
                            return x;
                         }
            public static cfg.shop.ShopRefreshInfo xml_unmarshal_cfg_shop_ShopRefreshInfo(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.shop.ShopRefreshInfo x;
                            switch(type) {
                            case "null": return null;
                            case "NotRefresh" : x = new cfg.shop.NotRefresh(ele); break;
                            case "DailyRefresh" : x = new cfg.shop.DailyRefresh(ele); break;
                            case "WeeklyRefresh" : x = new cfg.shop.WeeklyRefresh(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.sound.Sound> xml_unmarshal_list_cfg_sound_Sound(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.sound.Sound>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_sound_Sound(c));
                            }return x;
                         }
            public static cfg.skill.BulletTrackConfig xml_unmarshal_cfg_skill_BulletTrackConfig(XmlElement ele) {
                            var x = new cfg.skill.BulletTrackConfig(ele);
                            return x;
                         }
            public static cfg.map.OutDirFilterAdd xml_unmarshal_cfg_map_OutDirFilterAdd(XmlElement ele) {
                            var x = new cfg.map.OutDirFilterAdd(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.summon.SummonReward> xml_unmarshal_list_cfg_summon_SummonReward(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.summon.SummonReward>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_summon_SummonReward(c));
                            }return x;
                         }
            public static cfg.tower.TowerUpgradeInfo xml_unmarshal_cfg_tower_TowerUpgradeInfo(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.tower.TowerUpgradeInfo x;
                            switch(type) {
                            case "null": return null;
                            case "TowerUpgradeNoBuffInfo" : x = new cfg.tower.TowerUpgradeNoBuffInfo(ele); break;
                            case "TowerUpgradeWithBuffInfo" : x = new cfg.tower.TowerUpgradeWithBuffInfo(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.map.mapEventShowWeight> xml_unmarshal_list_cfg_map_mapEventShowWeight(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.map.mapEventShowWeight>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_map_mapEventShowWeight(c));
                            }return x;
                         }
            public static cfg.battle.MapBuild xml_unmarshal_cfg_battle_MapBuild(XmlElement ele) {
                            var x = new cfg.battle.MapBuild(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.asset.Asset> xml_unmarshal_list_cfg_asset_Asset(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.asset.Asset>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_asset_Asset(c));
                            }return x;
                         }
            public static cfg.localize.TexPositionElement xml_unmarshal_cfg_localize_TexPositionElement(XmlElement ele) {
                            var x = new cfg.localize.TexPositionElement(ele);
                            return x;
                         }
            public static cfg.bonus.Item xml_unmarshal_cfg_bonus_Item(XmlElement ele) {
                            var x = new cfg.bonus.Item(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.level.BattleLevel> xml_unmarshal_list_cfg_level_BattleLevel(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.level.BattleLevel>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_level_BattleLevel(c));
                            }return x;
                         }
            public static cfg.battle.MoneyWaveAdd xml_unmarshal_cfg_battle_MoneyWaveAdd(XmlElement ele) {
                            var x = new cfg.battle.MoneyWaveAdd(ele);
                            return x;
                         }
            public static cfg.skill.EffectUnlimit xml_unmarshal_cfg_skill_EffectUnlimit(XmlElement ele) {
                            var x = new cfg.skill.EffectUnlimit(ele);
                            return x;
                         }
            public static System.Collections.Generic.Dictionary<int,cfg.tower.TowerUpgradeInfo> xml_unmarshal_map_int_cfg_tower_TowerUpgradeInfo(XmlElement ele) {
                            var x = new System.Collections.Generic.Dictionary<int,cfg.tower.TowerUpgradeInfo>();
                            foreach(var c in ele.GetChildren()) {
                            var key = default(int);var value = default(cfg.tower.TowerUpgradeInfo);foreach(var c2 in c.GetChildren())
                            {
                            switch(c2.Name)
                            {
                            case "key": key = c2.ReadInt(); break;
                            case "value": value = cfg.Extensions.xml_unmarshal_cfg_tower_TowerUpgradeInfo(c2); break;
                            }
                            }
                            x.Add(key, value);
                            }return x;
                         }
            public static cfg.castle.CastleUpgradeReward xml_unmarshal_cfg_castle_CastleUpgradeReward(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.castle.CastleUpgradeReward x;
                            switch(type) {
                            case "null": return null;
                            case "CastleUpgradeNoReward" : x = new cfg.castle.CastleUpgradeNoReward(ele); break;
                            case "CastleUpgradeBonusReward" : x = new cfg.castle.CastleUpgradeBonusReward(ele); break;
                            case "CastleUpgradeSysBuffReward" : x = new cfg.castle.CastleUpgradeSysBuffReward(ele); break;
                            case "CastleUpgradeUserTitleReward" : x = new cfg.castle.CastleUpgradeUserTitleReward(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.map.mapEventShowWeight xml_unmarshal_cfg_map_mapEventShowWeight(XmlElement ele) {
                            var x = new cfg.map.mapEventShowWeight(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.attribute.Attribute> xml_unmarshal_list_cfg_attribute_Attribute(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.attribute.Attribute>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_attribute_Attribute(c));
                            }return x;
                         }
            public static cfg.item.Item xml_unmarshal_cfg_item_Item(XmlElement ele) {
                            var x = new cfg.item.Item(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.skill.BulletTrackConfig> xml_unmarshal_list_cfg_skill_BulletTrackConfig(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.skill.BulletTrackConfig>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_skill_BulletTrackConfig(c));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.level.ChapterBox> xml_unmarshal_list_cfg_level_ChapterBox(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.level.ChapterBox>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_level_ChapterBox(c));
                            }return x;
                         }
            public static cfg.sound.Sound xml_unmarshal_cfg_sound_Sound(XmlElement ele) {
                            var x = new cfg.sound.Sound(ele);
                            return x;
                         }
            public static cfg.hero.Hero xml_unmarshal_cfg_hero_Hero(XmlElement ele) {
                            var x = new cfg.hero.Hero(ele);
                            return x;
                         }
            public static cfg.Vector2Int xml_unmarshal_cfg_Vector2Int(XmlElement ele) {
                            var x = new cfg.Vector2Int(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.MapLevel> xml_unmarshal_list_cfg_battle_MapLevel(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.battle.MapLevel>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_battle_MapLevel(c));
                            }return x;
                         }
            public static cfg.shop.EveryDayFreeGoods xml_unmarshal_cfg_shop_EveryDayFreeGoods(XmlElement ele) {
                            var x = new cfg.shop.EveryDayFreeGoods(ele);
                            return x;
                         }
            public static cfg.attribute.AttributeLongNumber xml_unmarshal_cfg_attribute_AttributeLongNumber(XmlElement ele) {
                            var x = new cfg.attribute.AttributeLongNumber(ele);
                            return x;
                         }
            public static cfg.common.XFloat xml_unmarshal_cfg_common_XFloat(XmlElement ele) {
                            var x = new cfg.common.XFloat(ele);
                            return x;
                         }
            public static cfg.summon.SummonReward xml_unmarshal_cfg_summon_SummonReward(XmlElement ele) {
                            var x = new cfg.summon.SummonReward(ele);
                            return x;
                         }
            public static cfg.asset.Asset xml_unmarshal_cfg_asset_Asset(XmlElement ele) {
                            var x = new cfg.asset.Asset(ele);
                            return x;
                         }
            public static cfg.asset.AssetInfo xml_unmarshal_cfg_asset_AssetInfo(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.asset.AssetInfo x;
                            switch(type) {
                            case "null": return null;
                            case "Texture" : x = new cfg.asset.Texture(ele); break;
                            case "Sprite" : x = new cfg.asset.Sprite(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.function.AdGetCurrencyInfo xml_unmarshal_cfg_function_AdGetCurrencyInfo(XmlElement ele) {
                            var x = new cfg.function.AdGetCurrencyInfo(ele);
                            return x;
                         }
            public static cfg.skill.StackNum xml_unmarshal_cfg_skill_StackNum(XmlElement ele) {
                            var x = new cfg.skill.StackNum(ele);
                            return x;
                         }
            public static cfg.skill.Dizz xml_unmarshal_cfg_skill_Dizz(XmlElement ele) {
                            var x = new cfg.skill.Dizz(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.attribute.AttributeInfo> xml_unmarshal_list_cfg_attribute_AttributeInfo(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.attribute.AttributeInfo>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_attribute_AttributeInfo(c));
                            }return x;
                         }
            public static cfg.battle.HeroTarget xml_unmarshal_cfg_battle_HeroTarget(XmlElement ele) {
                            var x = new cfg.battle.HeroTarget(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.skill.BulletConfig> xml_unmarshal_list_cfg_skill_BulletConfig(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.skill.BulletConfig>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_skill_BulletConfig(c));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.item.Quality> xml_unmarshal_list_cfg_item_Quality(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.item.Quality>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_item_Quality(c));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.RefreshWave> xml_unmarshal_list_cfg_battle_RefreshWave(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.battle.RefreshWave>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_battle_RefreshWave(c));
                            }return x;
                         }
            public static cfg.shop.LimitByUser xml_unmarshal_cfg_shop_LimitByUser(XmlElement ele) {
                            var x = new cfg.shop.LimitByUser(ele);
                            return x;
                         }
            public static cfg.global.GBool xml_unmarshal_cfg_global_GBool(XmlElement ele) {
                            var x = new cfg.global.GBool(ele);
                            return x;
                         }
            public static cfg.shop.Shop xml_unmarshal_cfg_shop_Shop(XmlElement ele) {
                            var x = new cfg.shop.Shop(ele);
                            return x;
                         }
            public static cfg.skill.HitInterval xml_unmarshal_cfg_skill_HitInterval(XmlElement ele) {
                            var x = new cfg.skill.HitInterval(ele);
                            return x;
                         }
            public static cfg.bonus.MultiBonus xml_unmarshal_cfg_bonus_MultiBonus(XmlElement ele) {
                            var x = new cfg.bonus.MultiBonus(ele);
                            return x;
                         }
            public static cfg.skill.IntervalCheck xml_unmarshal_cfg_skill_IntervalCheck(XmlElement ele) {
                            var x = new cfg.skill.IntervalCheck(ele);
                            return x;
                         }
            public static cfg.skill.InTerrain xml_unmarshal_cfg_skill_InTerrain(XmlElement ele) {
                            var x = new cfg.skill.InTerrain(ele);
                            return x;
                         }
            public static cfg.function.JumpShopInfo xml_unmarshal_cfg_function_JumpShopInfo(XmlElement ele) {
                            var x = new cfg.function.JumpShopInfo(ele);
                            return x;
                         }
            public static cfg.skill.TerrainAddBuff xml_unmarshal_cfg_skill_TerrainAddBuff(XmlElement ele) {
                            var x = new cfg.skill.TerrainAddBuff(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.map.MapPath> xml_unmarshal_list_cfg_map_MapPath(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.map.MapPath>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_map_MapPath(c));
                            }return x;
                         }
            public static cfg.bonus.RandomBonus xml_unmarshal_cfg_bonus_RandomBonus(XmlElement ele) {
                            var x = new cfg.bonus.RandomBonus(ele);
                            return x;
                         }
            public static cfg.skill.ImmediateTrigger xml_unmarshal_cfg_skill_ImmediateTrigger(XmlElement ele) {
                            var x = new cfg.skill.ImmediateTrigger(ele);
                            return x;
                         }
            public static cfg.common.XLong xml_unmarshal_cfg_common_XLong(XmlElement ele) {
                            var x = new cfg.common.XLong(ele);
                            return x;
                         }
            public static cfg.skill.ReleaseSkill xml_unmarshal_cfg_skill_ReleaseSkill(XmlElement ele) {
                            var x = new cfg.skill.ReleaseSkill(ele);
                            return x;
                         }
            public static cfg.skill.BeforeTakeBuffEffect xml_unmarshal_cfg_skill_BeforeTakeBuffEffect(XmlElement ele) {
                            var x = new cfg.skill.BeforeTakeBuffEffect(ele);
                            return x;
                         }
            public static cfg.sysbuff.CastleAddAtkSlotSysBuff xml_unmarshal_cfg_sysbuff_CastleAddAtkSlotSysBuff(XmlElement ele) {
                            var x = new cfg.sysbuff.CastleAddAtkSlotSysBuff(ele);
                            return x;
                         }
            public static cfg.bonus.WeightRandomBonus xml_unmarshal_cfg_bonus_WeightRandomBonus(XmlElement ele) {
                            var x = new cfg.bonus.WeightRandomBonus(ele);
                            return x;
                         }
            public static cfg.global.GInt32 xml_unmarshal_cfg_global_GInt32(XmlElement ele) {
                            var x = new cfg.global.GInt32(ele);
                            return x;
                         }
            public static cfg.monster.Monster xml_unmarshal_cfg_monster_Monster(XmlElement ele) {
                            var x = new cfg.monster.Monster(ele);
                            return x;
                         }
            public static cfg.battle.BuildingTower xml_unmarshal_cfg_battle_BuildingTower(XmlElement ele) {
                            var x = new cfg.battle.BuildingTower(ele);
                            return x;
                         }
            public static cfg.skill.AfterTime xml_unmarshal_cfg_skill_AfterTime(XmlElement ele) {
                            var x = new cfg.skill.AfterTime(ele);
                            return x;
                         }
            public static cfg.Vector2 xml_unmarshal_cfg_Vector2(XmlElement ele) {
                            var x = new cfg.Vector2(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.attribute.AttributeLongNumber> xml_unmarshal_list_cfg_attribute_AttributeLongNumber(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.attribute.AttributeLongNumber>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_attribute_AttributeLongNumber(c));
                            }return x;
                         }
            public static cfg.common.AdCost xml_unmarshal_cfg_common_AdCost(XmlElement ele) {
                            var x = new cfg.common.AdCost(ele);
                            return x;
                         }
            public static cfg.battle.RandomBuffLib xml_unmarshal_cfg_battle_RandomBuffLib(XmlElement ele) {
                            var x = new cfg.battle.RandomBuffLib(ele);
                            return x;
                         }
            public static cfg.shop.NormalGoods xml_unmarshal_cfg_shop_NormalGoods(XmlElement ele) {
                            var x = new cfg.shop.NormalGoods(ele);
                            return x;
                         }
            public static cfg.skill.StateDisappear xml_unmarshal_cfg_skill_StateDisappear(XmlElement ele) {
                            var x = new cfg.skill.StateDisappear(ele);
                            return x;
                         }
            public static cfg.Vector3 xml_unmarshal_cfg_Vector3(XmlElement ele) {
                            var x = new cfg.Vector3(ele);
                            return x;
                         }
            public static cfg.skill.BuffStatcking xml_unmarshal_cfg_skill_BuffStatcking(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.skill.BuffStatcking x;
                            switch(type) {
                            case "null": return null;
                            case "StackNone" : x = new cfg.skill.StackNone(ele); break;
                            case "StackReset" : x = new cfg.skill.StackReset(ele); break;
                            case "StackNum" : x = new cfg.skill.StackNum(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.shop.CostType xml_unmarshal_cfg_shop_CostType(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.shop.CostType x;
                            switch(type) {
                            case "null": return null;
                            case "CurrencyCost" : x = new cfg.shop.CurrencyCost(ele); break;
                            case "Free" : x = new cfg.shop.Free(ele); break;
                            case "AdCost" : x = new cfg.shop.AdCost(ele); break;
                            case "MoneyCost" : x = new cfg.shop.MoneyCost(ele); break;
                            case "ItemCost" : x = new cfg.shop.ItemCost(ele); break;
                            case "MultiCost" : x = new cfg.shop.MultiCost(ele); break;
                            case "CostWithCount" : x = new cfg.shop.CostWithCount(ele); break;
                            case "CostWithInterval" : x = new cfg.shop.CostWithInterval(ele); break;
                            case "BatchCost" : x = new cfg.shop.BatchCost(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.global.GlobalInfo xml_unmarshal_cfg_global_GlobalInfo(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.global.GlobalInfo x;
                            switch(type) {
                            case "null": return null;
                            case "GInt32" : x = new cfg.global.GInt32(ele); break;
                            case "GInt64" : x = new cfg.global.GInt64(ele); break;
                            case "GString" : x = new cfg.global.GString(ele); break;
                            case "GFloat" : x = new cfg.global.GFloat(ele); break;
                            case "GBool" : x = new cfg.global.GBool(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.condition.CastleLevel xml_unmarshal_cfg_condition_CastleLevel(XmlElement ele) {
                            var x = new cfg.condition.CastleLevel(ele);
                            return x;
                         }
            public static cfg.condition.ChapterPass xml_unmarshal_cfg_condition_ChapterPass(XmlElement ele) {
                            var x = new cfg.condition.ChapterPass(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.global.Global> xml_unmarshal_list_cfg_global_Global(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.global.Global>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_global_Global(c));
                            }return x;
                         }
            public static cfg.common.MoneyCost xml_unmarshal_cfg_common_MoneyCost(XmlElement ele) {
                            var x = new cfg.common.MoneyCost(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.tower.TowerSlot> xml_unmarshal_list_cfg_tower_TowerSlot(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.tower.TowerSlot>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_tower_TowerSlot(c));
                            }return x;
                         }
            public static cfg.skill.FlyBullet xml_unmarshal_cfg_skill_FlyBullet(XmlElement ele) {
                            var x = new cfg.skill.FlyBullet(ele);
                            return x;
                         }
            public static cfg.common.ItemCost xml_unmarshal_cfg_common_ItemCost(XmlElement ele) {
                            var x = new cfg.common.ItemCost(ele);
                            return x;
                         }
            public static cfg.tower.TowerUpgradeNoBuffInfo xml_unmarshal_cfg_tower_TowerUpgradeNoBuffInfo(XmlElement ele) {
                            var x = new cfg.tower.TowerUpgradeNoBuffInfo(ele);
                            return x;
                         }
            public static cfg.battle.RefreshBuffFree xml_unmarshal_cfg_battle_RefreshBuffFree(XmlElement ele) {
                            var x = new cfg.battle.RefreshBuffFree(ele);
                            return x;
                         }
            public static cfg.shop.BatchCost xml_unmarshal_cfg_shop_BatchCost(XmlElement ele) {
                            var x = new cfg.shop.BatchCost(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.skill.BuffConfig> xml_unmarshal_list_cfg_skill_BuffConfig(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.skill.BuffConfig>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_skill_BuffConfig(c));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.skill.BuffChangeContent> xml_unmarshal_list_cfg_skill_BuffChangeContent(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.skill.BuffChangeContent>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_skill_BuffChangeContent(c));
                            }return x;
                         }
            public static cfg.shop.EveryDay xml_unmarshal_cfg_shop_EveryDay(XmlElement ele) {
                            var x = new cfg.shop.EveryDay(ele);
                            return x;
                         }
            public static cfg.skill.Interval xml_unmarshal_cfg_skill_Interval(XmlElement ele) {
                            var x = new cfg.skill.Interval(ele);
                            return x;
                         }
            public static cfg.sysbuff.SysBuffInfo xml_unmarshal_cfg_sysbuff_SysBuffInfo(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.sysbuff.SysBuffInfo x;
                            switch(type) {
                            case "null": return null;
                            case "TowerAttrSysBuff" : x = new cfg.sysbuff.TowerAttrSysBuff(ele); break;
                            case "CastleAttrSysBuff" : x = new cfg.sysbuff.CastleAttrSysBuff(ele); break;
                            case "BattleStartBuff" : x = new cfg.sysbuff.BattleStartBuff(ele); break;
                            case "CastleAddAtkSlotSysBuff" : x = new cfg.sysbuff.CastleAddAtkSlotSysBuff(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.asset.Texture xml_unmarshal_cfg_asset_Texture(XmlElement ele) {
                            var x = new cfg.asset.Texture(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.map.LevelUp> xml_unmarshal_list_cfg_map_LevelUp(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.map.LevelUp>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_map_LevelUp(c));
                            }return x;
                         }
            public static cfg.skill.DamageAdjust xml_unmarshal_cfg_skill_DamageAdjust(XmlElement ele) {
                            var x = new cfg.skill.DamageAdjust(ele);
                            return x;
                         }
            public static cfg.function.JumpInfo xml_unmarshal_cfg_function_JumpInfo(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.function.JumpInfo x;
                            switch(type) {
                            case "null": return null;
                            case "JumpShopInfo" : x = new cfg.function.JumpShopInfo(ele); break;
                            case "JumpBattleInfo" : x = new cfg.function.JumpBattleInfo(ele); break;
                            case "AdGetCurrencyInfo" : x = new cfg.function.AdGetCurrencyInfo(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.MapBuild> xml_unmarshal_list_cfg_battle_MapBuild(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.battle.MapBuild>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_battle_MapBuild(c));
                            }return x;
                         }
            public static cfg.bonus.RefBonus xml_unmarshal_cfg_bonus_RefBonus(XmlElement ele) {
                            var x = new cfg.bonus.RefBonus(ele);
                            return x;
                         }
            public static cfg.battle.RepeatCount xml_unmarshal_cfg_battle_RepeatCount(XmlElement ele) {
                            var x = new cfg.battle.RepeatCount(ele);
                            return x;
                         }
            public static cfg.skill.InFixTime xml_unmarshal_cfg_skill_InFixTime(XmlElement ele) {
                            var x = new cfg.skill.InFixTime(ele);
                            return x;
                         }
            public static cfg.skill.OtherControll xml_unmarshal_cfg_skill_OtherControll(XmlElement ele) {
                            var x = new cfg.skill.OtherControll(ele);
                            return x;
                         }
            public static cfg.battle.TotalTowerTarget xml_unmarshal_cfg_battle_TotalTowerTarget(XmlElement ele) {
                            var x = new cfg.battle.TotalTowerTarget(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.monster.Monster> xml_unmarshal_list_cfg_monster_Monster(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.monster.Monster>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_monster_Monster(c));
                            }return x;
                         }
            public static cfg.bonus.Currency xml_unmarshal_cfg_bonus_Currency(XmlElement ele) {
                            var x = new cfg.bonus.Currency(ele);
                            return x;
                         }
            public static cfg.sound.SoundEffect xml_unmarshal_cfg_sound_SoundEffect(XmlElement ele) {
                            var x = new cfg.sound.SoundEffect(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.shop.Shop> xml_unmarshal_list_cfg_shop_Shop(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.shop.Shop>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_shop_Shop(c));
                            }return x;
                         }
            public static cfg.shop.LimitBuyType xml_unmarshal_cfg_shop_LimitBuyType(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.shop.LimitBuyType x;
                            switch(type) {
                            case "null": return null;
                            case "NotLimit" : x = new cfg.shop.NotLimit(ele); break;
                            case "LimitByUser" : x = new cfg.shop.LimitByUser(ele); break;
                            case "EveryDay" : x = new cfg.shop.EveryDay(ele); break;
                            case "EveryWeek" : x = new cfg.shop.EveryWeek(ele); break;
                            case "EveryMonth" : x = new cfg.shop.EveryMonth(ele); break;
                            case "DayLimit" : x = new cfg.shop.DayLimit(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.level.ChapterBox xml_unmarshal_cfg_level_ChapterBox(XmlElement ele) {
                            var x = new cfg.level.ChapterBox(ele);
                            return x;
                         }
            public static cfg.castle.CastleUpgradeNoReward xml_unmarshal_cfg_castle_CastleUpgradeNoReward(XmlElement ele) {
                            var x = new cfg.castle.CastleUpgradeNoReward(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.shop.DailyDiscountWeight> xml_unmarshal_list_cfg_shop_DailyDiscountWeight(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.shop.DailyDiscountWeight>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_shop_DailyDiscountWeight(c));
                            }return x;
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
            public static cfg.bonus.ItemId xml_unmarshal_cfg_bonus_ItemId(XmlElement ele) {
                            var x = new cfg.bonus.ItemId(ele);
                            return x;
                         }
            public static cfg.skill.HitSpTypeMonster xml_unmarshal_cfg_skill_HitSpTypeMonster(XmlElement ele) {
                            var x = new cfg.skill.HitSpTypeMonster(ele);
                            return x;
                         }
            public static cfg.summon.SummonUpgrade xml_unmarshal_cfg_summon_SummonUpgrade(XmlElement ele) {
                            var x = new cfg.summon.SummonUpgrade(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.shop.GoodsInfo> xml_unmarshal_list_cfg_shop_GoodsInfo(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.shop.GoodsInfo>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_shop_GoodsInfo(c));
                            }return x;
                         }
            public static cfg.shop.NotLimit xml_unmarshal_cfg_shop_NotLimit(XmlElement ele) {
                            var x = new cfg.shop.NotLimit(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.RandomBuff> xml_unmarshal_list_cfg_battle_RandomBuff(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.battle.RandomBuff>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_battle_RandomBuff(c));
                            }return x;
                         }
            public static cfg.tower.Tower xml_unmarshal_cfg_tower_Tower(XmlElement ele) {
                            var x = new cfg.tower.Tower(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.SelectBuff> xml_unmarshal_list_cfg_battle_SelectBuff(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.battle.SelectBuff>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_battle_SelectBuff(c));
                            }return x;
                         }
            public static cfg.battle.RefreshWave xml_unmarshal_cfg_battle_RefreshWave(XmlElement ele) {
                            var x = new cfg.battle.RefreshWave(ele);
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
            public static System.Collections.Generic.List<cfg.bonus.Item> xml_unmarshal_list_cfg_bonus_Item(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.bonus.Item>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_bonus_Item(c));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.error.Error> xml_unmarshal_list_cfg_error_Error(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.error.Error>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_error_Error(c));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.RandomBuffLib> xml_unmarshal_list_cfg_battle_RandomBuffLib(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.battle.RandomBuffLib>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_battle_RandomBuffLib(c));
                            }return x;
                         }
            public static cfg.common.CurrencyGlobal xml_unmarshal_cfg_common_CurrencyGlobal(XmlElement ele) {
                            var x = new cfg.common.CurrencyGlobal(ele);
                            return x;
                         }
            public static cfg.battle.KillEnergyAdd xml_unmarshal_cfg_battle_KillEnergyAdd(XmlElement ele) {
                            var x = new cfg.battle.KillEnergyAdd(ele);
                            return x;
                         }
            public static cfg.condition.OwnItem xml_unmarshal_cfg_condition_OwnItem(XmlElement ele) {
                            var x = new cfg.condition.OwnItem(ele);
                            return x;
                         }
            public static cfg.skill.SplitBullet xml_unmarshal_cfg_skill_SplitBullet(XmlElement ele) {
                            var x = new cfg.skill.SplitBullet(ele);
                            return x;
                         }
            public static cfg.condition.And xml_unmarshal_cfg_condition_And(XmlElement ele) {
                            var x = new cfg.condition.And(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.shop.DailyGoodsRefresh> xml_unmarshal_list_cfg_shop_DailyGoodsRefresh(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.shop.DailyGoodsRefresh>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_shop_DailyGoodsRefresh(c));
                            }return x;
                         }
            public static System.Collections.Generic.List<int> xml_unmarshal_list_int(XmlElement ele) {
                            var x = new System.Collections.Generic.List<int>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(c.ReadInt());
                            }return x;
                         }
            public static cfg.castle.CastleSkillUpgradeInfo xml_unmarshal_cfg_castle_CastleSkillUpgradeInfo(XmlElement ele) {
                            var x = new cfg.castle.CastleSkillUpgradeInfo(ele);
                            return x;
                         }
            public static cfg.item.Quality xml_unmarshal_cfg_item_Quality(XmlElement ele) {
                            var x = new cfg.item.Quality(ele);
                            return x;
                         }
            public static cfg.skill.HitTarget xml_unmarshal_cfg_skill_HitTarget(XmlElement ele) {
                            var x = new cfg.skill.HitTarget(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.sysbuff.SysBuff> xml_unmarshal_list_cfg_sysbuff_SysBuff(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.sysbuff.SysBuff>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_sysbuff_SysBuff(c));
                            }return x;
                         }
            public static cfg.shop.DayLimit xml_unmarshal_cfg_shop_DayLimit(XmlElement ele) {
                            var x = new cfg.shop.DayLimit(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.shop.DailyGoods> xml_unmarshal_list_cfg_shop_DailyGoods(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.shop.DailyGoods>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_shop_DailyGoods(c));
                            }return x;
                         }
            public static cfg.shop.DailyGoodsRefresh xml_unmarshal_cfg_shop_DailyGoodsRefresh(XmlElement ele) {
                            var x = new cfg.shop.DailyGoodsRefresh(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.item.Item> xml_unmarshal_list_cfg_item_Item(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.item.Item>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_item_Item(c));
                            }return x;
                         }
            public static cfg.skill.Immediate xml_unmarshal_cfg_skill_Immediate(XmlElement ele) {
                            var x = new cfg.skill.Immediate(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.tower.TowerUpgrade> xml_unmarshal_list_cfg_tower_TowerUpgrade(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.tower.TowerUpgrade>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_tower_TowerUpgrade(c));
                            }return x;
                         }
            public static cfg.tower.LockSlot xml_unmarshal_cfg_tower_LockSlot(XmlElement ele) {
                            var x = new cfg.tower.LockSlot(ele);
                            return x;
                         }
            public static cfg.shop.WeeklyRefresh xml_unmarshal_cfg_shop_WeeklyRefresh(XmlElement ele) {
                            var x = new cfg.shop.WeeklyRefresh(ele);
                            return x;
                         }
            public static cfg.skill.NoramlRelease xml_unmarshal_cfg_skill_NoramlRelease(XmlElement ele) {
                            var x = new cfg.skill.NoramlRelease(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.tower.Tower> xml_unmarshal_list_cfg_tower_Tower(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.tower.Tower>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_tower_Tower(c));
                            }return x;
                         }
            public static cfg.shop.Free xml_unmarshal_cfg_shop_Free(XmlElement ele) {
                            var x = new cfg.shop.Free(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.skill.SkillReleaseConfig> xml_unmarshal_list_cfg_skill_SkillReleaseConfig(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.skill.SkillReleaseConfig>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_skill_SkillReleaseConfig(c));
                            }return x;
                         }
            public static cfg.skill.BuffChange xml_unmarshal_cfg_skill_BuffChange(XmlElement ele) {
                            var x = new cfg.skill.BuffChange(ele);
                            return x;
                         }
            public static cfg.skill.CreateBulletDataFinish xml_unmarshal_cfg_skill_CreateBulletDataFinish(XmlElement ele) {
                            var x = new cfg.skill.CreateBulletDataFinish(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.localize.TexLocalizeElement> xml_unmarshal_list_cfg_localize_TexLocalizeElement(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.localize.TexLocalizeElement>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_localize_TexLocalizeElement(c));
                            }return x;
                         }
            public static cfg.localize.TexAssetElement xml_unmarshal_cfg_localize_TexAssetElement(XmlElement ele) {
                            var x = new cfg.localize.TexAssetElement(ele);
                            return x;
                         }
            public static cfg.battle.AddQualityAboveBuffWeight xml_unmarshal_cfg_battle_AddQualityAboveBuffWeight(XmlElement ele) {
                            var x = new cfg.battle.AddQualityAboveBuffWeight(ele);
                            return x;
                         }
            public static cfg.skill.BulletDestroyType xml_unmarshal_cfg_skill_BulletDestroyType(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.skill.BulletDestroyType x;
                            switch(type) {
                            case "null": return null;
                            case "EffectOnce" : x = new cfg.skill.EffectOnce(ele); break;
                            case "EffectNum" : x = new cfg.skill.EffectNum(ele); break;
                            case "EffectUnlimit" : x = new cfg.skill.EffectUnlimit(ele); break;
                            case "AfterTime" : x = new cfg.skill.AfterTime(ele); break;
                            case "OtherControll" : x = new cfg.skill.OtherControll(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.shop.DailyDiscountWeight xml_unmarshal_cfg_shop_DailyDiscountWeight(XmlElement ele) {
                            var x = new cfg.shop.DailyDiscountWeight(ele);
                            return x;
                         }
            public static cfg.sysbuff.TowerAttrSysBuff xml_unmarshal_cfg_sysbuff_TowerAttrSysBuff(XmlElement ele) {
                            var x = new cfg.sysbuff.TowerAttrSysBuff(ele);
                            return x;
                         }
            public static cfg.global.Global xml_unmarshal_cfg_global_Global(XmlElement ele) {
                            var x = new cfg.global.Global(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.shop.CostType> xml_unmarshal_list_cfg_shop_CostType(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.shop.CostType>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_shop_CostType(c));
                            }return x;
                         }
            public static System.Collections.Generic.Dictionary<int,cfg.castle.CastleSkillUpgradeInfo> xml_unmarshal_map_int_cfg_castle_CastleSkillUpgradeInfo(XmlElement ele) {
                            var x = new System.Collections.Generic.Dictionary<int,cfg.castle.CastleSkillUpgradeInfo>();
                            foreach(var c in ele.GetChildren()) {
                            var key = default(int);var value = default(cfg.castle.CastleSkillUpgradeInfo);foreach(var c2 in c.GetChildren())
                            {
                            switch(c2.Name)
                            {
                            case "key": key = c2.ReadInt(); break;
                            case "value": value = cfg.Extensions.xml_unmarshal_cfg_castle_CastleSkillUpgradeInfo(c2); break;
                            }
                            }
                            x.Add(key, value);
                            }return x;
                         }
            public static cfg.castle.Castle xml_unmarshal_cfg_castle_Castle(XmlElement ele) {
                            var x = new cfg.castle.Castle(ele);
                            return x;
                         }
            public static cfg.sysbuff.SysBuff xml_unmarshal_cfg_sysbuff_SysBuff(XmlElement ele) {
                            var x = new cfg.sysbuff.SysBuff(ele);
                            return x;
                         }
            public static cfg.skill.AfterTakeBuffEffect xml_unmarshal_cfg_skill_AfterTakeBuffEffect(XmlElement ele) {
                            var x = new cfg.skill.AfterTakeBuffEffect(ele);
                            return x;
                         }
            public static cfg.shop.DailyShopInfo xml_unmarshal_cfg_shop_DailyShopInfo(XmlElement ele) {
                            var x = new cfg.shop.DailyShopInfo(ele);
                            return x;
                         }
            public static cfg.battle.StartBuff xml_unmarshal_cfg_battle_StartBuff(XmlElement ele) {
                            var x = new cfg.battle.StartBuff(ele);
                            return x;
                         }
            public static cfg.bonus.Items xml_unmarshal_cfg_bonus_Items(XmlElement ele) {
                            var x = new cfg.bonus.Items(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.condition.Condition> xml_unmarshal_list_cfg_condition_Condition(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.condition.Condition>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_condition_Condition(c));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.shop.SellInfo> xml_unmarshal_list_cfg_shop_SellInfo(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.shop.SellInfo>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_shop_SellInfo(c));
                            }return x;
                         }
            public static cfg.localize.TexLocalizeElement xml_unmarshal_cfg_localize_TexLocalizeElement(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.localize.TexLocalizeElement x;
                            switch(type) {
                            case "null": return null;
                            case "TexAssetElement" : x = new cfg.localize.TexAssetElement(ele); break;
                            case "TexLocalizeElements" : x = new cfg.localize.TexLocalizeElements(ele); break;
                            case "TexPositionElement" : x = new cfg.localize.TexPositionElement(ele); break;
                            case "TexScaleElement" : x = new cfg.localize.TexScaleElement(ele); break;
                            case "TexSizeElement" : x = new cfg.localize.TexSizeElement(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.skill.SkillReleaseConfig xml_unmarshal_cfg_skill_SkillReleaseConfig(XmlElement ele) {
                            var x = new cfg.skill.SkillReleaseConfig(ele);
                            return x;
                         }
            public static cfg.level.BattleLevel xml_unmarshal_cfg_level_BattleLevel(XmlElement ele) {
                            var x = new cfg.level.BattleLevel(ele);
                            return x;
                         }
            public static cfg.battle.MapLevel xml_unmarshal_cfg_battle_MapLevel(XmlElement ele) {
                            var x = new cfg.battle.MapLevel(ele);
                            return x;
                         }
            public static cfg.bonus.RandomTowerFragmentQuality xml_unmarshal_cfg_bonus_RandomTowerFragmentQuality(XmlElement ele) {
                            var x = new cfg.bonus.RandomTowerFragmentQuality(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.bonus.WeightBonus> xml_unmarshal_list_cfg_bonus_WeightBonus(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.bonus.WeightBonus>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_bonus_WeightBonus(c));
                            }return x;
                         }
            public static cfg.global.GString xml_unmarshal_cfg_global_GString(XmlElement ele) {
                            var x = new cfg.global.GString(ele);
                            return x;
                         }
            public static cfg.castle.CastleUpgradeBonusReward xml_unmarshal_cfg_castle_CastleUpgradeBonusReward(XmlElement ele) {
                            var x = new cfg.castle.CastleUpgradeBonusReward(ele);
                            return x;
                         }
            public static System.Collections.Generic.Dictionary<cfg.localize.ELanguageType,cfg.localize.TexLocalizeElement> xml_unmarshal_map_cfg_localize_ELanguageType_cfg_localize_TexLocalizeElement(XmlElement ele) {
                            var x = new System.Collections.Generic.Dictionary<cfg.localize.ELanguageType,cfg.localize.TexLocalizeElement>();
                            foreach(var c in ele.GetChildren()) {
                            var key = default(cfg.localize.ELanguageType);var value = default(cfg.localize.TexLocalizeElement);foreach(var c2 in c.GetChildren())
                            {
                            switch(c2.Name)
                            {
                            case "key": key = c2.ReadEnum<cfg.localize.ELanguageType>(); break;
                            case "value": value = cfg.Extensions.xml_unmarshal_cfg_localize_TexLocalizeElement(c2); break;
                            }
                            }
                            x.Add(key, value);
                            }return x;
                         }
            public static cfg.skill.PathBullet xml_unmarshal_cfg_skill_PathBullet(XmlElement ele) {
                            var x = new cfg.skill.PathBullet(ele);
                            return x;
                         }
            public static cfg.skill.BulletEffectType xml_unmarshal_cfg_skill_BulletEffectType(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.skill.BulletEffectType x;
                            switch(type) {
                            case "null": return null;
                            case "HitFixTarget" : x = new cfg.skill.HitFixTarget(ele); break;
                            case "HitAnyOne" : x = new cfg.skill.HitAnyOne(ele); break;
                            case "HitImmediate" : x = new cfg.skill.HitImmediate(ele); break;
                            case "HitDelay" : x = new cfg.skill.HitDelay(ele); break;
                            case "HitInterval" : x = new cfg.skill.HitInterval(ele); break;
                            case "IntervalCheck" : x = new cfg.skill.IntervalCheck(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.StartBuff> xml_unmarshal_list_cfg_battle_StartBuff(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.battle.StartBuff>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_battle_StartBuff(c));
                            }return x;
                         }
            public static cfg.skill.BulletChange xml_unmarshal_cfg_skill_BulletChange(XmlElement ele) {
                            var x = new cfg.skill.BulletChange(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.castle.CastleAttrUpInfo> xml_unmarshal_list_cfg_castle_CastleAttrUpInfo(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.castle.CastleAttrUpInfo>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_castle_CastleAttrUpInfo(c));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.localize.TextureLanguage> xml_unmarshal_list_cfg_localize_TextureLanguage(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.localize.TextureLanguage>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_localize_TextureLanguage(c));
                            }return x;
                         }
            public static cfg.tower.DefaultTowerSlot xml_unmarshal_cfg_tower_DefaultTowerSlot(XmlElement ele) {
                            var x = new cfg.tower.DefaultTowerSlot(ele);
                            return x;
                         }
            public static cfg.skill.AttributeChange xml_unmarshal_cfg_skill_AttributeChange(XmlElement ele) {
                            var x = new cfg.skill.AttributeChange(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.RefreshMonster> xml_unmarshal_list_cfg_battle_RefreshMonster(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.battle.RefreshMonster>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_battle_RefreshMonster(c));
                            }return x;
                         }
            public static cfg.battle.SelectBuff xml_unmarshal_cfg_battle_SelectBuff(XmlElement ele) {
                            var x = new cfg.battle.SelectBuff(ele);
                            return x;
                         }
            public static cfg.shop.SellItem xml_unmarshal_cfg_shop_SellItem(XmlElement ele) {
                            var x = new cfg.shop.SellItem(ele);
                            return x;
                         }
            public static cfg.skill.BuffTriggerType xml_unmarshal_cfg_skill_BuffTriggerType(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.skill.BuffTriggerType x;
                            switch(type) {
                            case "null": return null;
                            case "ImmediateTrigger" : x = new cfg.skill.ImmediateTrigger(ele); break;
                            case "HitTarget" : x = new cfg.skill.HitTarget(ele); break;
                            case "ReleaseBullet" : x = new cfg.skill.ReleaseBullet(ele); break;
                            case "ReleaseSkill" : x = new cfg.skill.ReleaseSkill(ele); break;
                            case "CreateBulletDataFinish" : x = new cfg.skill.CreateBulletDataFinish(ele); break;
                            case "BeforeTakeBuffEffect" : x = new cfg.skill.BeforeTakeBuffEffect(ele); break;
                            case "AfterTakeBuffEffect" : x = new cfg.skill.AfterTakeBuffEffect(ele); break;
                            case "BeforeDeadHaveState" : x = new cfg.skill.BeforeDeadHaveState(ele); break;
                            case "HitStateTarget" : x = new cfg.skill.HitStateTarget(ele); break;
                            case "HitSpTypeMonster" : x = new cfg.skill.HitSpTypeMonster(ele); break;
                            case "InTerrain" : x = new cfg.skill.InTerrain(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.skill.HitStateTarget xml_unmarshal_cfg_skill_HitStateTarget(XmlElement ele) {
                            var x = new cfg.skill.HitStateTarget(ele);
                            return x;
                         }
            public static cfg.condition.Currency xml_unmarshal_cfg_condition_Currency(XmlElement ele) {
                            var x = new cfg.condition.Currency(ele);
                            return x;
                         }
            public static cfg.condition.Condition xml_unmarshal_cfg_condition_Condition(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.condition.Condition x;
                            switch(type) {
                            case "null": return null;
                            case "None" : x = new cfg.condition.None(ele); break;
                            case "Currency" : x = new cfg.condition.Currency(ele); break;
                            case "Item" : x = new cfg.condition.Item(ele); break;
                            case "BuyMonthlyCard" : x = new cfg.condition.BuyMonthlyCard(ele); break;
                            case "OwnItem" : x = new cfg.condition.OwnItem(ele); break;
                            case "ChapterPass" : x = new cfg.condition.ChapterPass(ele); break;
                            case "CastleLevel" : x = new cfg.condition.CastleLevel(ele); break;
                            case "And" : x = new cfg.condition.And(ele); break;
                            case "Or" : x = new cfg.condition.Or(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.bonus.Bonus> xml_unmarshal_list_cfg_bonus_Bonus(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.bonus.Bonus>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_bonus_Bonus(c));
                            }return x;
                         }
            public static cfg.battle.EffectTarget xml_unmarshal_cfg_battle_EffectTarget(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.battle.EffectTarget x;
                            switch(type) {
                            case "null": return null;
                            case "CastleTarget" : x = new cfg.battle.CastleTarget(ele); break;
                            case "HeroTarget" : x = new cfg.battle.HeroTarget(ele); break;
                            case "SingeTowerTarget" : x = new cfg.battle.SingeTowerTarget(ele); break;
                            case "SpDamageTypeTowerTarget" : x = new cfg.battle.SpDamageTypeTowerTarget(ele); break;
                            case "TotalTowerTarget" : x = new cfg.battle.TotalTowerTarget(ele); break;
                            case "EnemyTarget" : x = new cfg.battle.EnemyTarget(ele); break;
                            case "GlobalTarget" : x = new cfg.battle.GlobalTarget(ele); break;
                            case "KillExpAdd" : x = new cfg.battle.KillExpAdd(ele); break;
                            case "KillEnergyAdd" : x = new cfg.battle.KillEnergyAdd(ele); break;
                            case "MoneyWaveAdd" : x = new cfg.battle.MoneyWaveAdd(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.skill.Forever xml_unmarshal_cfg_skill_Forever(XmlElement ele) {
                            var x = new cfg.skill.Forever(ele);
                            return x;
                         }
            public static cfg.common.Currency xml_unmarshal_cfg_common_Currency(XmlElement ele) {
                            var x = new cfg.common.Currency(ele);
                            return x;
                         }
            public static cfg.common.CurrencyCost xml_unmarshal_cfg_common_CurrencyCost(XmlElement ele) {
                            var x = new cfg.common.CurrencyCost(ele);
                            return x;
                         }
            public static cfg.skill.StackReset xml_unmarshal_cfg_skill_StackReset(XmlElement ele) {
                            var x = new cfg.skill.StackReset(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.bonus.BonusData> xml_unmarshal_list_cfg_bonus_BonusData(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.bonus.BonusData>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_bonus_BonusData(c));
                            }return x;
                         }
            public static cfg.bonus.Empty xml_unmarshal_cfg_bonus_Empty(XmlElement ele) {
                            var x = new cfg.bonus.Empty(ele);
                            return x;
                         }
            public static cfg.attribute.AttributeInfo xml_unmarshal_cfg_attribute_AttributeInfo(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.attribute.AttributeInfo x;
                            switch(type) {
                            case "null": return null;
                            case "None" : x = new cfg.attribute.None(ele); break;
                            case "AttributeNumber" : x = new cfg.attribute.AttributeNumber(ele); break;
                            case "AttributeLongNumber" : x = new cfg.attribute.AttributeLongNumber(ele); break;
                            case "And" : x = new cfg.attribute.And(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.castle.CastleUpgrade> xml_unmarshal_list_cfg_castle_CastleUpgrade(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.castle.CastleUpgrade>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_castle_CastleUpgrade(c));
                            }return x;
                         }
            public static cfg.common.XInt xml_unmarshal_cfg_common_XInt(XmlElement ele) {
                            var x = new cfg.common.XInt(ele);
                            return x;
                         }
            public static cfg.item.TowerFragmentInfo xml_unmarshal_cfg_item_TowerFragmentInfo(XmlElement ele) {
                            var x = new cfg.item.TowerFragmentInfo(ele);
                            return x;
                         }
            public static cfg.shop.SellGift xml_unmarshal_cfg_shop_SellGift(XmlElement ele) {
                            var x = new cfg.shop.SellGift(ele);
                            return x;
                         }
            public static cfg.skill.BeamBullet xml_unmarshal_cfg_skill_BeamBullet(XmlElement ele) {
                            var x = new cfg.skill.BeamBullet(ele);
                            return x;
                         }
            public static cfg.skill.StackNone xml_unmarshal_cfg_skill_StackNone(XmlElement ele) {
                            var x = new cfg.skill.StackNone(ele);
                            return x;
                         }
            public static cfg.skill.AttackDamage xml_unmarshal_cfg_skill_AttackDamage(XmlElement ele) {
                            var x = new cfg.skill.AttackDamage(ele);
                            return x;
                         }
            public static cfg.battle.BuildingRoad xml_unmarshal_cfg_battle_BuildingRoad(XmlElement ele) {
                            var x = new cfg.battle.BuildingRoad(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.user.UserTitle> xml_unmarshal_list_cfg_user_UserTitle(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.user.UserTitle>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_user_UserTitle(c));
                            }return x;
                         }
            public static cfg.condition.BuyMonthlyCard xml_unmarshal_cfg_condition_BuyMonthlyCard(XmlElement ele) {
                            var x = new cfg.condition.BuyMonthlyCard(ele);
                            return x;
                         }
            public static System.Collections.Generic.Dictionary<cfg.summon.ESummonType,cfg.bonus.Bonus> xml_unmarshal_map_cfg_summon_ESummonType_cfg_bonus_Bonus(XmlElement ele) {
                            var x = new System.Collections.Generic.Dictionary<cfg.summon.ESummonType,cfg.bonus.Bonus>();
                            foreach(var c in ele.GetChildren()) {
                            var key = default(cfg.summon.ESummonType);var value = default(cfg.bonus.Bonus);foreach(var c2 in c.GetChildren())
                            {
                            switch(c2.Name)
                            {
                            case "key": key = c2.ReadEnum<cfg.summon.ESummonType>(); break;
                            case "value": value = cfg.Extensions.xml_unmarshal_cfg_bonus_Bonus(c2); break;
                            }
                            }
                            x.Add(key, value);
                            }return x;
                         }
            public static cfg.tower.Empty xml_unmarshal_cfg_tower_Empty(XmlElement ele) {
                            var x = new cfg.tower.Empty(ele);
                            return x;
                         }
            public static cfg.skill.ReleaseNumCritical xml_unmarshal_cfg_skill_ReleaseNumCritical(XmlElement ele) {
                            var x = new cfg.skill.ReleaseNumCritical(ele);
                            return x;
                         }
            public static cfg.sound.Music xml_unmarshal_cfg_sound_Music(XmlElement ele) {
                            var x = new cfg.sound.Music(ele);
                            return x;
                         }
            public static System.Collections.Generic.Dictionary<int,cfg.castle.AttrUpgradeInfo> xml_unmarshal_map_int_cfg_castle_AttrUpgradeInfo(XmlElement ele) {
                            var x = new System.Collections.Generic.Dictionary<int,cfg.castle.AttrUpgradeInfo>();
                            foreach(var c in ele.GetChildren()) {
                            var key = default(int);var value = default(cfg.castle.AttrUpgradeInfo);foreach(var c2 in c.GetChildren())
                            {
                            switch(c2.Name)
                            {
                            case "key": key = c2.ReadInt(); break;
                            case "value": value = cfg.Extensions.xml_unmarshal_cfg_castle_AttrUpgradeInfo(c2); break;
                            }
                            }
                            x.Add(key, value);
                            }return x;
                         }
            public static cfg.skill.ReleaseBullet xml_unmarshal_cfg_skill_ReleaseBullet(XmlElement ele) {
                            var x = new cfg.skill.ReleaseBullet(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.castle.CastleSkill> xml_unmarshal_list_cfg_castle_CastleSkill(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.castle.CastleSkill>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_castle_CastleSkill(c));
                            }return x;
                         }
            public static cfg.shop.MultiCost xml_unmarshal_cfg_shop_MultiCost(XmlElement ele) {
                            var x = new cfg.shop.MultiCost(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.map.OutDirFilterAdd> xml_unmarshal_list_cfg_map_OutDirFilterAdd(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.map.OutDirFilterAdd>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_map_OutDirFilterAdd(c));
                            }return x;
                         }
            public static cfg.castle.CastleAttrUpInfo xml_unmarshal_cfg_castle_CastleAttrUpInfo(XmlElement ele) {
                            var x = new cfg.castle.CastleAttrUpInfo(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.map.mapEvent> xml_unmarshal_list_cfg_map_mapEvent(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.map.mapEvent>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_map_mapEvent(c));
                            }return x;
                         }
            public static cfg.skill.ReleasePlusBullet xml_unmarshal_cfg_skill_ReleasePlusBullet(XmlElement ele) {
                            var x = new cfg.skill.ReleasePlusBullet(ele);
                            return x;
                         }
            public static cfg.skill.EffectOnce xml_unmarshal_cfg_skill_EffectOnce(XmlElement ele) {
                            var x = new cfg.skill.EffectOnce(ele);
                            return x;
                         }
            public static cfg.global.GFloat xml_unmarshal_cfg_global_GFloat(XmlElement ele) {
                            var x = new cfg.global.GFloat(ele);
                            return x;
                         }
            public static cfg.battle.CastleTarget xml_unmarshal_cfg_battle_CastleTarget(XmlElement ele) {
                            var x = new cfg.battle.CastleTarget(ele);
                            return x;
                         }
            public static cfg.item.SummonInfo xml_unmarshal_cfg_item_SummonInfo(XmlElement ele) {
                            var x = new cfg.item.SummonInfo(ele);
                            return x;
                         }
            public static cfg.shop.AdCost xml_unmarshal_cfg_shop_AdCost(XmlElement ele) {
                            var x = new cfg.shop.AdCost(ele);
                            return x;
                         }
            public static cfg.localize.TextureLanguage xml_unmarshal_cfg_localize_TextureLanguage(XmlElement ele) {
                            var x = new cfg.localize.TextureLanguage(ele);
                            return x;
                         }
            public static cfg.battle.BuildingType xml_unmarshal_cfg_battle_BuildingType(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.battle.BuildingType x;
                            switch(type) {
                            case "null": return null;
                            case "BuildingRoad" : x = new cfg.battle.BuildingRoad(ele); break;
                            case "BuildingTower" : x = new cfg.battle.BuildingTower(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.skill.SkillPropertyChange xml_unmarshal_cfg_skill_SkillPropertyChange(XmlElement ele) {
                            var x = new cfg.skill.SkillPropertyChange(ele);
                            return x;
                         }
            public static cfg.skill.ReleaseFlashBullet xml_unmarshal_cfg_skill_ReleaseFlashBullet(XmlElement ele) {
                            var x = new cfg.skill.ReleaseFlashBullet(ele);
                            return x;
                         }
            public static cfg.tower.SlotInfo xml_unmarshal_cfg_tower_SlotInfo(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.tower.SlotInfo x;
                            switch(type) {
                            case "null": return null;
                            case "Empty" : x = new cfg.tower.Empty(ele); break;
                            case "DefaultTowerSlot" : x = new cfg.tower.DefaultTowerSlot(ele); break;
                            case "LockSlot" : x = new cfg.tower.LockSlot(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.tower.TowerUpgrade xml_unmarshal_cfg_tower_TowerUpgrade(XmlElement ele) {
                            var x = new cfg.tower.TowerUpgrade(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.summon.Summon> xml_unmarshal_list_cfg_summon_Summon(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.summon.Summon>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_summon_Summon(c));
                            }return x;
                         }
            public static cfg.battle.BattleRefresh xml_unmarshal_cfg_battle_BattleRefresh(XmlElement ele) {
                            var x = new cfg.battle.BattleRefresh(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.map.MapGround> xml_unmarshal_list_cfg_map_MapGround(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.map.MapGround>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_map_MapGround(c));
                            }return x;
                         }
            public static cfg.shop.EveryWeek xml_unmarshal_cfg_shop_EveryWeek(XmlElement ele) {
                            var x = new cfg.shop.EveryWeek(ele);
                            return x;
                         }
            public static cfg.map.mapEvent xml_unmarshal_cfg_map_mapEvent(XmlElement ele) {
                            var x = new cfg.map.mapEvent(ele);
                            return x;
                         }
            public static cfg.common.None xml_unmarshal_cfg_common_None(XmlElement ele) {
                            var x = new cfg.common.None(ele);
                            return x;
                         }
            public static cfg.shop.NromalShopInfo xml_unmarshal_cfg_shop_NromalShopInfo(XmlElement ele) {
                            var x = new cfg.shop.NromalShopInfo(ele);
                            return x;
                         }
            public static cfg.bonus.Bonus xml_unmarshal_cfg_bonus_Bonus(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.bonus.Bonus x;
                            switch(type) {
                            case "null": return null;
                            case "Empty" : x = new cfg.bonus.Empty(ele); break;
                            case "RefBonus" : x = new cfg.bonus.RefBonus(ele); break;
                            case "Currency" : x = new cfg.bonus.Currency(ele); break;
                            case "ItemId" : x = new cfg.bonus.ItemId(ele); break;
                            case "Item" : x = new cfg.bonus.Item(ele); break;
                            case "Items" : x = new cfg.bonus.Items(ele); break;
                            case "RandomTowerFragmentQuality" : x = new cfg.bonus.RandomTowerFragmentQuality(ele); break;
                            case "WeightBonus" : x = new cfg.bonus.WeightBonus(ele); break;
                            case "RandomBonus" : x = new cfg.bonus.RandomBonus(ele); break;
                            case "WeightRandomBonus" : x = new cfg.bonus.WeightRandomBonus(ele); break;
                            case "MultiBonus" : x = new cfg.bonus.MultiBonus(ele); break;
                            case "RepeatBonus" : x = new cfg.bonus.RepeatBonus(ele); break;
                            case "CopyBonus" : x = new cfg.bonus.CopyBonus(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.common.Currency> xml_unmarshal_list_cfg_common_Currency(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.common.Currency>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_common_Currency(c));
                            }return x;
                         }
            public static cfg.battle.EnemyTarget xml_unmarshal_cfg_battle_EnemyTarget(XmlElement ele) {
                            var x = new cfg.battle.EnemyTarget(ele);
                            return x;
                         }
            public static cfg.attribute.Attribute xml_unmarshal_cfg_attribute_Attribute(XmlElement ele) {
                            var x = new cfg.attribute.Attribute(ele);
                            return x;
                         }
            public static cfg.castle.AttrUpgradeInfo xml_unmarshal_cfg_castle_AttrUpgradeInfo(XmlElement ele) {
                            var x = new cfg.castle.AttrUpgradeInfo(ele);
                            return x;
                         }
            public static cfg.attribute.None xml_unmarshal_cfg_attribute_None(XmlElement ele) {
                            var x = new cfg.attribute.None(ele);
                            return x;
                         }
            public static cfg.castle.CastleUpgrade xml_unmarshal_cfg_castle_CastleUpgrade(XmlElement ele) {
                            var x = new cfg.castle.CastleUpgrade(ele);
                            return x;
                         }
            public static cfg.skill.BuffEffectContent xml_unmarshal_cfg_skill_BuffEffectContent(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.skill.BuffEffectContent x;
                            switch(type) {
                            case "null": return null;
                            case "AttributeChange" : x = new cfg.skill.AttributeChange(ele); break;
                            case "DamageAdjust" : x = new cfg.skill.DamageAdjust(ele); break;
                            case "HpChange" : x = new cfg.skill.HpChange(ele); break;
                            case "SkillPropertyChange" : x = new cfg.skill.SkillPropertyChange(ele); break;
                            case "ReleasePlusBullet" : x = new cfg.skill.ReleasePlusBullet(ele); break;
                            case "SplitBullet" : x = new cfg.skill.SplitBullet(ele); break;
                            case "BulletChange" : x = new cfg.skill.BulletChange(ele); break;
                            case "BuffChange" : x = new cfg.skill.BuffChange(ele); break;
                            case "AOEPlusDamage" : x = new cfg.skill.AOEPlusDamage(ele); break;
                            case "Fire" : x = new cfg.skill.Fire(ele); break;
                            case "Frozen" : x = new cfg.skill.Frozen(ele); break;
                            case "Dizz" : x = new cfg.skill.Dizz(ele); break;
                            case "HitBack" : x = new cfg.skill.HitBack(ele); break;
                            case "ReleaseFlashBullet" : x = new cfg.skill.ReleaseFlashBullet(ele); break;
                            case "AttackDamage" : x = new cfg.skill.AttackDamage(ele); break;
                            case "AddBuff" : x = new cfg.skill.AddBuff(ele); break;
                            case "TerrainAddBuff" : x = new cfg.skill.TerrainAddBuff(ele); break;
                            case "ReleaseNumCritical" : x = new cfg.skill.ReleaseNumCritical(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.common.Cost> xml_unmarshal_list_cfg_common_Cost(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.common.Cost>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_common_Cost(c));
                            }return x;
                         }
            public static System.Collections.Generic.List<cfg.hero.Hero> xml_unmarshal_list_cfg_hero_Hero(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.hero.Hero>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_hero_Hero(c));
                            }return x;
                         }
            public static cfg.common.Or xml_unmarshal_cfg_common_Or(XmlElement ele) {
                            var x = new cfg.common.Or(ele);
                            return x;
                         }
            public static cfg.localize.TexScaleElement xml_unmarshal_cfg_localize_TexScaleElement(XmlElement ele) {
                            var x = new cfg.localize.TexScaleElement(ele);
                            return x;
                         }
            public static cfg.bonus.BonusData xml_unmarshal_cfg_bonus_BonusData(XmlElement ele) {
                            var x = new cfg.bonus.BonusData(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.BattleAsset> xml_unmarshal_list_cfg_battle_BattleAsset(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.battle.BattleAsset>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_battle_BattleAsset(c));
                            }return x;
                         }
            public static cfg.bonus.WeightBonus xml_unmarshal_cfg_bonus_WeightBonus(XmlElement ele) {
                            var x = new cfg.bonus.WeightBonus(ele);
                            return x;
                         }
            public static cfg.skill.AOEPlusDamage xml_unmarshal_cfg_skill_AOEPlusDamage(XmlElement ele) {
                            var x = new cfg.skill.AOEPlusDamage(ele);
                            return x;
                         }
            public static cfg.skill.HitBack xml_unmarshal_cfg_skill_HitBack(XmlElement ele) {
                            var x = new cfg.skill.HitBack(ele);
                            return x;
                         }
            public static cfg.battle.BattleIncomeAdd xml_unmarshal_cfg_battle_BattleIncomeAdd(XmlElement ele) {
                            var x = new cfg.battle.BattleIncomeAdd(ele);
                            return x;
                         }
            public static cfg.battle.SpDamageTypeTowerTarget xml_unmarshal_cfg_battle_SpDamageTypeTowerTarget(XmlElement ele) {
                            var x = new cfg.battle.SpDamageTypeTowerTarget(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.RandomBuffLibContent> xml_unmarshal_list_cfg_battle_RandomBuffLibContent(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.battle.RandomBuffLibContent>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_battle_RandomBuffLibContent(c));
                            }return x;
                         }
            public static cfg.shop.NotRefresh xml_unmarshal_cfg_shop_NotRefresh(XmlElement ele) {
                            var x = new cfg.shop.NotRefresh(ele);
                            return x;
                         }
            public static cfg.attribute.AttributeNumber xml_unmarshal_cfg_attribute_AttributeNumber(XmlElement ele) {
                            var x = new cfg.attribute.AttributeNumber(ele);
                            return x;
                         }
            public static cfg.skill.SkillReleaseType xml_unmarshal_cfg_skill_SkillReleaseType(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.skill.SkillReleaseType x;
                            switch(type) {
                            case "null": return null;
                            case "NoramlRelease" : x = new cfg.skill.NoramlRelease(ele); break;
                            case "ReleaseBuff" : x = new cfg.skill.ReleaseBuff(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.shop.EveryMonth xml_unmarshal_cfg_shop_EveryMonth(XmlElement ele) {
                            var x = new cfg.shop.EveryMonth(ele);
                            return x;
                         }
            public static cfg.shop.CurrencyCost xml_unmarshal_cfg_shop_CurrencyCost(XmlElement ele) {
                            var x = new cfg.shop.CurrencyCost(ele);
                            return x;
                         }
            public static cfg.skill.BuffEffectType xml_unmarshal_cfg_skill_BuffEffectType(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.skill.BuffEffectType x;
                            switch(type) {
                            case "null": return null;
                            case "Immediate" : x = new cfg.skill.Immediate(ele); break;
                            case "Delay" : x = new cfg.skill.Delay(ele); break;
                            case "Interval" : x = new cfg.skill.Interval(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.bonus.RepeatBonus xml_unmarshal_cfg_bonus_RepeatBonus(XmlElement ele) {
                            var x = new cfg.bonus.RepeatBonus(ele);
                            return x;
                         }
            public static cfg.map.LevelUp xml_unmarshal_cfg_map_LevelUp(XmlElement ele) {
                            var x = new cfg.map.LevelUp(ele);
                            return x;
                         }
            public static cfg.condition.Item xml_unmarshal_cfg_condition_Item(XmlElement ele) {
                            var x = new cfg.condition.Item(ele);
                            return x;
                         }
            public static cfg.attribute.And xml_unmarshal_cfg_attribute_And(XmlElement ele) {
                            var x = new cfg.attribute.And(ele);
                            return x;
                         }
            public static cfg.item.GiftInfo xml_unmarshal_cfg_item_GiftInfo(XmlElement ele) {
                            var x = new cfg.item.GiftInfo(ele);
                            return x;
                         }
            public static cfg.skill.AfterExcute xml_unmarshal_cfg_skill_AfterExcute(XmlElement ele) {
                            var x = new cfg.skill.AfterExcute(ele);
                            return x;
                         }
            public static cfg.asset.Sprite xml_unmarshal_cfg_asset_Sprite(XmlElement ele) {
                            var x = new cfg.asset.Sprite(ele);
                            return x;
                         }
            public static cfg.sysbuff.CastleAttrSysBuff xml_unmarshal_cfg_sysbuff_CastleAttrSysBuff(XmlElement ele) {
                            var x = new cfg.sysbuff.CastleAttrSysBuff(ele);
                            return x;
                         }
            public static cfg.battle.SelectCount xml_unmarshal_cfg_battle_SelectCount(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.battle.SelectCount x;
                            switch(type) {
                            case "null": return null;
                            case "RepeatCount" : x = new cfg.battle.RepeatCount(ele); break;
                            case "SingleCount" : x = new cfg.battle.SingleCount(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.map.EPathDir> xml_unmarshal_list_cfg_map_EPathDir(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.map.EPathDir>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(c.ReadEnum<cfg.map.EPathDir>());
                            }return x;
                         }
            public static cfg.shop.SellInfo xml_unmarshal_cfg_shop_SellInfo(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.shop.SellInfo x;
                            switch(type) {
                            case "null": return null;
                            case "SellItem" : x = new cfg.shop.SellItem(ele); break;
                            case "SellCurrency" : x = new cfg.shop.SellCurrency(ele); break;
                            case "SellGift" : x = new cfg.shop.SellGift(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.battle.BattleAsset xml_unmarshal_cfg_battle_BattleAsset(XmlElement ele) {
                            var x = new cfg.battle.BattleAsset(ele);
                            return x;
                         }
            public static cfg.map.MapPath xml_unmarshal_cfg_map_MapPath(XmlElement ele) {
                            var x = new cfg.map.MapPath(ele);
                            return x;
                         }
            public static cfg.shop.CostWithCount xml_unmarshal_cfg_shop_CostWithCount(XmlElement ele) {
                            var x = new cfg.shop.CostWithCount(ele);
                            return x;
                         }
            public static cfg.battle.SingleCount xml_unmarshal_cfg_battle_SingleCount(XmlElement ele) {
                            var x = new cfg.battle.SingleCount(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.battle.BattleRefresh> xml_unmarshal_list_cfg_battle_BattleRefresh(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.battle.BattleRefresh>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_battle_BattleRefresh(c));
                            }return x;
                         }
            public static cfg.skill.BulletType xml_unmarshal_cfg_skill_BulletType(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.skill.BulletType x;
                            switch(type) {
                            case "null": return null;
                            case "FlyBullet" : x = new cfg.skill.FlyBullet(ele); break;
                            case "ImmediateBullet" : x = new cfg.skill.ImmediateBullet(ele); break;
                            case "BeamBullet" : x = new cfg.skill.BeamBullet(ele); break;
                            case "PathBullet" : x = new cfg.skill.PathBullet(ele); break;
                            case "TerrainBullet" : x = new cfg.skill.TerrainBullet(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.condition.Or xml_unmarshal_cfg_condition_Or(XmlElement ele) {
                            var x = new cfg.condition.Or(ele);
                            return x;
                         }
            public static cfg.common.And xml_unmarshal_cfg_common_And(XmlElement ele) {
                            var x = new cfg.common.And(ele);
                            return x;
                         }
            public static cfg.battle.SelectBuffType3Trigger xml_unmarshal_cfg_battle_SelectBuffType3Trigger(XmlElement ele) {
                            var type = ele.GetAttribute("type");
                            cfg.battle.SelectBuffType3Trigger x;
                            switch(type) {
                            case "null": return null;
                            case "CastleHpDownto" : x = new cfg.battle.CastleHpDownto(ele); break;
                            default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                            return x;
                         }
            public static cfg.level.Chapter xml_unmarshal_cfg_level_Chapter(XmlElement ele) {
                            var x = new cfg.level.Chapter(ele);
                            return x;
                         }
            public static cfg.localize.Language xml_unmarshal_cfg_localize_Language(XmlElement ele) {
                            var x = new cfg.localize.Language(ele);
                            return x;
                         }
            public static System.Collections.Generic.List<cfg.function.Jump> xml_unmarshal_list_cfg_function_Jump(XmlElement ele) {
                            var x = new System.Collections.Generic.List<cfg.function.Jump>();
                            foreach(var c in ele.GetChildren()) {
                            x.Add(cfg.Extensions.xml_unmarshal_cfg_function_Jump(c));
                            }return x;
                         }
            public static cfg.shop.MoneyCost xml_unmarshal_cfg_shop_MoneyCost(XmlElement ele) {
                            var x = new cfg.shop.MoneyCost(ele);
                            return x;
                         }

        }
    }
}
