using System.Xml;
using System;
using System.IO;
using System.Collections.Generic;

namespace editor
{
    namespace cfg
    {
        public sealed class CfgMgr
        {
            public delegate byte[] onLoadConfigDelegate(string file);
            public static string BinDir { get; set; } = "config";

            public static string XmlDir { get; set; } = "csv";
            public static onLoadConfigDelegate onLoadConfig;

            public static volatile CfgMgr Ins;

            private Dictionary<string, bool> configNotLoadDic = new Dictionary<string, bool>();

            private Perfect.Marshal.Octets CreateOctets(string file)
            {
                return new Perfect.Marshal.Octets(onLoadConfig?.Invoke(file));
            }

            private static List<string> GetDirFileNames(string[] dirs)
            {
                List<string> dirNames = new List<string>();
                foreach (string dir in dirs)
                {
                    string[] fileNames = Directory.GetFiles(XmlDir + "/" + dir);
                    dirNames.AddRange(fileNames);
                }

                return dirNames;
            }

            private static XmlElement CreateXmlElement(string file)
            {
                var doc = new XmlDocument();
                doc.Load(file);
                return doc.DocumentElement;
            }

            private System.Collections.Generic.Dictionary<string,cfg.asset.Asset> assetMap;
            public cfg.asset.Asset GetAsset(string key) { return assetMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<string,cfg.asset.Asset> GetAssetMap() { return assetMap; }
            private System.Collections.Generic.List<cfg.asset.Asset> assetList;
            public System.Collections.Generic.List<cfg.asset.Asset> GetAssetList() { return assetList; }
             private System.Collections.Generic.Dictionary<string,cfg.localize.Language> languageMap;
            public cfg.localize.Language GetLanguage(string key) { return languageMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<string,cfg.localize.Language> GetLanguageMap() { return languageMap; }
            private System.Collections.Generic.List<cfg.localize.Language> languageList;
            public System.Collections.Generic.List<cfg.localize.Language> GetLanguageList() { return languageList; }
             private System.Collections.Generic.Dictionary<string,cfg.localize.TextureLanguage> texturelanguageMap;
            public cfg.localize.TextureLanguage GetTextureLanguage(string key) { return texturelanguageMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<string,cfg.localize.TextureLanguage> GetTextureLanguageMap() { return texturelanguageMap; }
            private System.Collections.Generic.List<cfg.localize.TextureLanguage> texturelanguageList;
            public System.Collections.Generic.List<cfg.localize.TextureLanguage> GetTextureLanguageList() { return texturelanguageList; }
             private System.Collections.Generic.Dictionary<string,cfg.sound.Sound> soundMap;
            public cfg.sound.Sound GetSound(string key) { return soundMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<string,cfg.sound.Sound> GetSoundMap() { return soundMap; }
            private System.Collections.Generic.List<cfg.sound.Sound> soundList;
            public System.Collections.Generic.List<cfg.sound.Sound> GetSoundList() { return soundList; }
             private System.Collections.Generic.Dictionary<string,cfg.global.Global> globalMap;
            public cfg.global.Global GetGlobal(string key) { return globalMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<string,cfg.global.Global> GetGlobalMap() { return globalMap; }
            private System.Collections.Generic.List<cfg.global.Global> globalList;
            public System.Collections.Generic.List<cfg.global.Global> GetGlobalList() { return globalList; }
             private cfg.common.CurrencyGlobal currencyglobal;
            public cfg.common.CurrencyGlobal GetCurrencyGlobal() { return currencyglobal; }
             private System.Collections.Generic.Dictionary<cfg.common.ECurrencyType,cfg.common.Currency> currencyMap;
            public cfg.common.Currency GetCurrency(cfg.common.ECurrencyType key) { return currencyMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<cfg.common.ECurrencyType,cfg.common.Currency> GetCurrencyMap() { return currencyMap; }
            private System.Collections.Generic.List<cfg.common.Currency> currencyList;
            public System.Collections.Generic.List<cfg.common.Currency> GetCurrencyList() { return currencyList; }
             private System.Collections.Generic.Dictionary<cfg.attribute.EAttributeType,cfg.attribute.Attribute> attributeMap;
            public cfg.attribute.Attribute GetAttribute(cfg.attribute.EAttributeType key) { return attributeMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<cfg.attribute.EAttributeType,cfg.attribute.Attribute> GetAttributeMap() { return attributeMap; }
            private System.Collections.Generic.List<cfg.attribute.Attribute> attributeList;
            public System.Collections.Generic.List<cfg.attribute.Attribute> GetAttributeList() { return attributeList; }
             private System.Collections.Generic.Dictionary<int,cfg.item.Item> itemMap;
            public cfg.item.Item GetItem(int key) { return itemMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.item.Item> GetItemMap() { return itemMap; }
            private System.Collections.Generic.List<cfg.item.Item> itemList;
            public System.Collections.Generic.List<cfg.item.Item> GetItemList() { return itemList; }
             private System.Collections.Generic.Dictionary<cfg.item.EItemQuality,cfg.item.Quality> qualityMap;
            public cfg.item.Quality GetQuality(cfg.item.EItemQuality key) { return qualityMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<cfg.item.EItemQuality,cfg.item.Quality> GetQualityMap() { return qualityMap; }
            private System.Collections.Generic.List<cfg.item.Quality> qualityList;
            public System.Collections.Generic.List<cfg.item.Quality> GetQualityList() { return qualityList; }
             private System.Collections.Generic.Dictionary<int,cfg.bonus.BonusData> bonusdataMap;
            public cfg.bonus.BonusData GetBonusData(int key) { return bonusdataMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.bonus.BonusData> GetBonusDataMap() { return bonusdataMap; }
            private System.Collections.Generic.List<cfg.bonus.BonusData> bonusdataList;
            public System.Collections.Generic.List<cfg.bonus.BonusData> GetBonusDataList() { return bonusdataList; }
             private System.Collections.Generic.Dictionary<string,cfg.error.Error> errorMap;
            public cfg.error.Error GetError(string key) { return errorMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<string,cfg.error.Error> GetErrorMap() { return errorMap; }
            private System.Collections.Generic.List<cfg.error.Error> errorList;
            public System.Collections.Generic.List<cfg.error.Error> GetErrorList() { return errorList; }
             private System.Collections.Generic.Dictionary<int,cfg.map.MapGround> mapgroundMap;
            public cfg.map.MapGround GetMapGround(int key) { return mapgroundMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.map.MapGround> GetMapGroundMap() { return mapgroundMap; }
            private System.Collections.Generic.List<cfg.map.MapGround> mapgroundList;
            public System.Collections.Generic.List<cfg.map.MapGround> GetMapGroundList() { return mapgroundList; }
             private System.Collections.Generic.Dictionary<int,cfg.map.LevelUp> levelupMap;
            public cfg.map.LevelUp GetLevelUp(int key) { return levelupMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.map.LevelUp> GetLevelUpMap() { return levelupMap; }
            private System.Collections.Generic.List<cfg.map.LevelUp> levelupList;
            public System.Collections.Generic.List<cfg.map.LevelUp> GetLevelUpList() { return levelupList; }
             private System.Collections.Generic.Dictionary<int,cfg.level.Chapter> chapterMap;
            public cfg.level.Chapter GetChapter(int key) { return chapterMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.level.Chapter> GetChapterMap() { return chapterMap; }
            private System.Collections.Generic.List<cfg.level.Chapter> chapterList;
            public System.Collections.Generic.List<cfg.level.Chapter> GetChapterList() { return chapterList; }
             private System.Collections.Generic.Dictionary<cfg.level.ELevelType,cfg.level.BattleLevel> battlelevelMap;
            public cfg.level.BattleLevel GetBattleLevel(cfg.level.ELevelType key) { return battlelevelMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<cfg.level.ELevelType,cfg.level.BattleLevel> GetBattleLevelMap() { return battlelevelMap; }
            private System.Collections.Generic.List<cfg.level.BattleLevel> battlelevelList;
            public System.Collections.Generic.List<cfg.level.BattleLevel> GetBattleLevelList() { return battlelevelList; }
             private System.Collections.Generic.Dictionary<int,cfg.hero.Hero> heroMap;
            public cfg.hero.Hero GetHero(int key) { return heroMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.hero.Hero> GetHeroMap() { return heroMap; }
            private System.Collections.Generic.List<cfg.hero.Hero> heroList;
            public System.Collections.Generic.List<cfg.hero.Hero> GetHeroList() { return heroList; }
             private System.Collections.Generic.Dictionary<int,cfg.skill.SkillReleaseConfig> skillreleaseconfigMap;
            public cfg.skill.SkillReleaseConfig GetSkillReleaseConfig(int key) { return skillreleaseconfigMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.skill.SkillReleaseConfig> GetSkillReleaseConfigMap() { return skillreleaseconfigMap; }
            private System.Collections.Generic.List<cfg.skill.SkillReleaseConfig> skillreleaseconfigList;
            public System.Collections.Generic.List<cfg.skill.SkillReleaseConfig> GetSkillReleaseConfigList() { return skillreleaseconfigList; }
             private System.Collections.Generic.Dictionary<int,cfg.skill.BuffConfig> buffconfigMap;
            public cfg.skill.BuffConfig GetBuffConfig(int key) { return buffconfigMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.skill.BuffConfig> GetBuffConfigMap() { return buffconfigMap; }
            private System.Collections.Generic.List<cfg.skill.BuffConfig> buffconfigList;
            public System.Collections.Generic.List<cfg.skill.BuffConfig> GetBuffConfigList() { return buffconfigList; }
             private System.Collections.Generic.Dictionary<int,cfg.skill.BulletConfig> bulletconfigMap;
            public cfg.skill.BulletConfig GetBulletConfig(int key) { return bulletconfigMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.skill.BulletConfig> GetBulletConfigMap() { return bulletconfigMap; }
            private System.Collections.Generic.List<cfg.skill.BulletConfig> bulletconfigList;
            public System.Collections.Generic.List<cfg.skill.BulletConfig> GetBulletConfigList() { return bulletconfigList; }
             private System.Collections.Generic.Dictionary<int,cfg.skill.BulletTrackConfig> bullettrackconfigMap;
            public cfg.skill.BulletTrackConfig GetBulletTrackConfig(int key) { return bullettrackconfigMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.skill.BulletTrackConfig> GetBulletTrackConfigMap() { return bullettrackconfigMap; }
            private System.Collections.Generic.List<cfg.skill.BulletTrackConfig> bullettrackconfigList;
            public System.Collections.Generic.List<cfg.skill.BulletTrackConfig> GetBulletTrackConfigList() { return bullettrackconfigList; }
             private System.Collections.Generic.Dictionary<cfg.tower.ETowerType,cfg.tower.Tower> towerMap;
            public cfg.tower.Tower GetTower(cfg.tower.ETowerType key) { return towerMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<cfg.tower.ETowerType,cfg.tower.Tower> GetTowerMap() { return towerMap; }
            private System.Collections.Generic.List<cfg.tower.Tower> towerList;
            public System.Collections.Generic.List<cfg.tower.Tower> GetTowerList() { return towerList; }
             private System.Collections.Generic.Dictionary<cfg.tower.ETowerType,cfg.tower.TowerUpgrade> towerupgradeMap;
            public cfg.tower.TowerUpgrade GetTowerUpgrade(cfg.tower.ETowerType key) { return towerupgradeMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<cfg.tower.ETowerType,cfg.tower.TowerUpgrade> GetTowerUpgradeMap() { return towerupgradeMap; }
            private System.Collections.Generic.List<cfg.tower.TowerUpgrade> towerupgradeList;
            public System.Collections.Generic.List<cfg.tower.TowerUpgrade> GetTowerUpgradeList() { return towerupgradeList; }
             private System.Collections.Generic.Dictionary<int,cfg.tower.TowerSlot> towerslotMap;
            public cfg.tower.TowerSlot GetTowerSlot(int key) { return towerslotMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.tower.TowerSlot> GetTowerSlotMap() { return towerslotMap; }
            private System.Collections.Generic.List<cfg.tower.TowerSlot> towerslotList;
            public System.Collections.Generic.List<cfg.tower.TowerSlot> GetTowerSlotList() { return towerslotList; }
             private System.Collections.Generic.Dictionary<int,cfg.monster.Monster> monsterMap;
            public cfg.monster.Monster GetMonster(int key) { return monsterMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.monster.Monster> GetMonsterMap() { return monsterMap; }
            private System.Collections.Generic.List<cfg.monster.Monster> monsterList;
            public System.Collections.Generic.List<cfg.monster.Monster> GetMonsterList() { return monsterList; }
             private cfg.castle.Castle castle;
            public cfg.castle.Castle GetCastle() { return castle; }
             private System.Collections.Generic.Dictionary<int,cfg.castle.CastleUpgrade> castleupgradeMap;
            public cfg.castle.CastleUpgrade GetCastleUpgrade(int key) { return castleupgradeMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.castle.CastleUpgrade> GetCastleUpgradeMap() { return castleupgradeMap; }
            private System.Collections.Generic.List<cfg.castle.CastleUpgrade> castleupgradeList;
            public System.Collections.Generic.List<cfg.castle.CastleUpgrade> GetCastleUpgradeList() { return castleupgradeList; }
             private System.Collections.Generic.Dictionary<int,cfg.castle.CastleSkill> castleskillMap;
            public cfg.castle.CastleSkill GetCastleSkill(int key) { return castleskillMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.castle.CastleSkill> GetCastleSkillMap() { return castleskillMap; }
            private System.Collections.Generic.List<cfg.castle.CastleSkill> castleskillList;
            public System.Collections.Generic.List<cfg.castle.CastleSkill> GetCastleSkillList() { return castleskillList; }
             private System.Collections.Generic.Dictionary<int,cfg.battle.BattleAsset> battleassetMap;
            public cfg.battle.BattleAsset GetBattleAsset(int key) { return battleassetMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.battle.BattleAsset> GetBattleAssetMap() { return battleassetMap; }
            private System.Collections.Generic.List<cfg.battle.BattleAsset> battleassetList;
            public System.Collections.Generic.List<cfg.battle.BattleAsset> GetBattleAssetList() { return battleassetList; }
             private System.Collections.Generic.Dictionary<int,cfg.battle.SelectBuff> selectbuffMap;
            public cfg.battle.SelectBuff GetSelectBuff(int key) { return selectbuffMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.battle.SelectBuff> GetSelectBuffMap() { return selectbuffMap; }
            private System.Collections.Generic.List<cfg.battle.SelectBuff> selectbuffList;
            public System.Collections.Generic.List<cfg.battle.SelectBuff> GetSelectBuffList() { return selectbuffList; }
             private System.Collections.Generic.Dictionary<int,cfg.battle.RandomBuff> randombuffMap;
            public cfg.battle.RandomBuff GetRandomBuff(int key) { return randombuffMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.battle.RandomBuff> GetRandomBuffMap() { return randombuffMap; }
            private System.Collections.Generic.List<cfg.battle.RandomBuff> randombuffList;
            public System.Collections.Generic.List<cfg.battle.RandomBuff> GetRandomBuffList() { return randombuffList; }
             private System.Collections.Generic.Dictionary<int,cfg.battle.StartBuff> startbuffMap;
            public cfg.battle.StartBuff GetStartBuff(int key) { return startbuffMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.battle.StartBuff> GetStartBuffMap() { return startbuffMap; }
            private System.Collections.Generic.List<cfg.battle.StartBuff> startbuffList;
            public System.Collections.Generic.List<cfg.battle.StartBuff> GetStartBuffList() { return startbuffList; }
             private System.Collections.Generic.Dictionary<int,cfg.battle.BattleRefresh> battlerefreshMap;
            public cfg.battle.BattleRefresh GetBattleRefresh(int key) { return battlerefreshMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.battle.BattleRefresh> GetBattleRefreshMap() { return battlerefreshMap; }
            private System.Collections.Generic.List<cfg.battle.BattleRefresh> battlerefreshList;
            public System.Collections.Generic.List<cfg.battle.BattleRefresh> GetBattleRefreshList() { return battlerefreshList; }
             private System.Collections.Generic.Dictionary<int,cfg.battle.MapLevel> maplevelMap;
            public cfg.battle.MapLevel GetMapLevel(int key) { return maplevelMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.battle.MapLevel> GetMapLevelMap() { return maplevelMap; }
            private System.Collections.Generic.List<cfg.battle.MapLevel> maplevelList;
            public System.Collections.Generic.List<cfg.battle.MapLevel> GetMapLevelList() { return maplevelList; }
             private System.Collections.Generic.Dictionary<int,cfg.battle.MapBuild> mapbuildMap;
            public cfg.battle.MapBuild GetMapBuild(int key) { return mapbuildMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.battle.MapBuild> GetMapBuildMap() { return mapbuildMap; }
            private System.Collections.Generic.List<cfg.battle.MapBuild> mapbuildList;
            public System.Collections.Generic.List<cfg.battle.MapBuild> GetMapBuildList() { return mapbuildList; }
             private System.Collections.Generic.Dictionary<int,cfg.map.MapPath> mappathMap;
            public cfg.map.MapPath GetMapPath(int key) { return mappathMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.map.MapPath> GetMapPathMap() { return mappathMap; }
            private System.Collections.Generic.List<cfg.map.MapPath> mappathList;
            public System.Collections.Generic.List<cfg.map.MapPath> GetMapPathList() { return mappathList; }
             private System.Collections.Generic.Dictionary<cfg.map.EPathDir,cfg.map.MapOutDirFilter> mapoutdirfilterMap;
            public cfg.map.MapOutDirFilter GetMapOutDirFilter(cfg.map.EPathDir key) { return mapoutdirfilterMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<cfg.map.EPathDir,cfg.map.MapOutDirFilter> GetMapOutDirFilterMap() { return mapoutdirfilterMap; }
            private System.Collections.Generic.List<cfg.map.MapOutDirFilter> mapoutdirfilterList;
            public System.Collections.Generic.List<cfg.map.MapOutDirFilter> GetMapOutDirFilterList() { return mapoutdirfilterList; }
             private System.Collections.Generic.Dictionary<int,cfg.map.mapEventShowWeight> mapeventshowweightMap;
            public cfg.map.mapEventShowWeight GetmapEventShowWeight(int key) { return mapeventshowweightMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.map.mapEventShowWeight> GetmapEventShowWeightMap() { return mapeventshowweightMap; }
            private System.Collections.Generic.List<cfg.map.mapEventShowWeight> mapeventshowweightList;
            public System.Collections.Generic.List<cfg.map.mapEventShowWeight> GetmapEventShowWeightList() { return mapeventshowweightList; }
             private System.Collections.Generic.Dictionary<cfg.map.EMapGridCfgType,cfg.map.mapEvent> mapeventMap;
            public cfg.map.mapEvent GetmapEvent(cfg.map.EMapGridCfgType key) { return mapeventMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<cfg.map.EMapGridCfgType,cfg.map.mapEvent> GetmapEventMap() { return mapeventMap; }
            private System.Collections.Generic.List<cfg.map.mapEvent> mapeventList;
            public System.Collections.Generic.List<cfg.map.mapEvent> GetmapEventList() { return mapeventList; }
             private System.Collections.Generic.Dictionary<int,cfg.user.UserTitle> usertitleMap;
            public cfg.user.UserTitle GetUserTitle(int key) { return usertitleMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.user.UserTitle> GetUserTitleMap() { return usertitleMap; }
            private System.Collections.Generic.List<cfg.user.UserTitle> usertitleList;
            public System.Collections.Generic.List<cfg.user.UserTitle> GetUserTitleList() { return usertitleList; }
             private System.Collections.Generic.Dictionary<cfg.summon.ESummonType,cfg.summon.Summon> summonMap;
            public cfg.summon.Summon GetSummon(cfg.summon.ESummonType key) { return summonMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<cfg.summon.ESummonType,cfg.summon.Summon> GetSummonMap() { return summonMap; }
            private System.Collections.Generic.List<cfg.summon.Summon> summonList;
            public System.Collections.Generic.List<cfg.summon.Summon> GetSummonList() { return summonList; }
             private System.Collections.Generic.Dictionary<cfg.summon.ESummonType,cfg.summon.SummonReward> summonrewardMap;
            public cfg.summon.SummonReward GetSummonReward(cfg.summon.ESummonType key) { return summonrewardMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<cfg.summon.ESummonType,cfg.summon.SummonReward> GetSummonRewardMap() { return summonrewardMap; }
            private System.Collections.Generic.List<cfg.summon.SummonReward> summonrewardList;
            public System.Collections.Generic.List<cfg.summon.SummonReward> GetSummonRewardList() { return summonrewardList; }
             private System.Collections.Generic.Dictionary<int,cfg.summon.SummonUpgrade> summonupgradeMap;
            public cfg.summon.SummonUpgrade GetSummonUpgrade(int key) { return summonupgradeMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.summon.SummonUpgrade> GetSummonUpgradeMap() { return summonupgradeMap; }
            private System.Collections.Generic.List<cfg.summon.SummonUpgrade> summonupgradeList;
            public System.Collections.Generic.List<cfg.summon.SummonUpgrade> GetSummonUpgradeList() { return summonupgradeList; }
             private System.Collections.Generic.Dictionary<int,cfg.sysbuff.SysBuff> sysbuffMap;
            public cfg.sysbuff.SysBuff GetSysBuff(int key) { return sysbuffMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.sysbuff.SysBuff> GetSysBuffMap() { return sysbuffMap; }
            private System.Collections.Generic.List<cfg.sysbuff.SysBuff> sysbuffList;
            public System.Collections.Generic.List<cfg.sysbuff.SysBuff> GetSysBuffList() { return sysbuffList; }
             private System.Collections.Generic.Dictionary<cfg.shop.EShopType,cfg.shop.Shop> shopMap;
            public cfg.shop.Shop GetShop(cfg.shop.EShopType key) { return shopMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<cfg.shop.EShopType,cfg.shop.Shop> GetShopMap() { return shopMap; }
            private System.Collections.Generic.List<cfg.shop.Shop> shopList;
            public System.Collections.Generic.List<cfg.shop.Shop> GetShopList() { return shopList; }
             private System.Collections.Generic.Dictionary<int,cfg.shop.DailyGoods> dailygoodsMap;
            public cfg.shop.DailyGoods GetDailyGoods(int key) { return dailygoodsMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.shop.DailyGoods> GetDailyGoodsMap() { return dailygoodsMap; }
            private System.Collections.Generic.List<cfg.shop.DailyGoods> dailygoodsList;
            public System.Collections.Generic.List<cfg.shop.DailyGoods> GetDailyGoodsList() { return dailygoodsList; }
             private System.Collections.Generic.Dictionary<int,cfg.shop.DailyDiscountWeight> dailydiscountweightMap;
            public cfg.shop.DailyDiscountWeight GetDailyDiscountWeight(int key) { return dailydiscountweightMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.shop.DailyDiscountWeight> GetDailyDiscountWeightMap() { return dailydiscountweightMap; }
            private System.Collections.Generic.List<cfg.shop.DailyDiscountWeight> dailydiscountweightList;
            public System.Collections.Generic.List<cfg.shop.DailyDiscountWeight> GetDailyDiscountWeightList() { return dailydiscountweightList; }
             private System.Collections.Generic.Dictionary<int,cfg.shop.DailyGoodsRefresh> dailygoodsrefreshMap;
            public cfg.shop.DailyGoodsRefresh GetDailyGoodsRefresh(int key) { return dailygoodsrefreshMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.shop.DailyGoodsRefresh> GetDailyGoodsRefreshMap() { return dailygoodsrefreshMap; }
            private System.Collections.Generic.List<cfg.shop.DailyGoodsRefresh> dailygoodsrefreshList;
            public System.Collections.Generic.List<cfg.shop.DailyGoodsRefresh> GetDailyGoodsRefreshList() { return dailygoodsrefreshList; }
             private System.Collections.Generic.Dictionary<int,cfg.function.Jump> jumpMap;
            public cfg.function.Jump GetJump(int key) { return jumpMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<int,cfg.function.Jump> GetJumpMap() { return jumpMap; }
            private System.Collections.Generic.List<cfg.function.Jump> jumpList;
            public System.Collections.Generic.List<cfg.function.Jump> GetJumpList() { return jumpList; }
             

            private CfgMgr() {
                var assetOctets = CreateOctets("asset.bytes");
                if(assetOctets != null)
                {
                assetList = cfg.Extensions.unmarshal_list_cfg_asset_Asset(assetOctets);
                assetMap = new System.Collections.Generic.Dictionary<string,cfg.asset.Asset>();
                foreach(var v in assetList) { assetMap.Add(v.assetId, v); }
                }
                else{
                configNotLoadDic.Add("asset.bytes", false);
                }
                 
                var languageOctets = CreateOctets("language.bytes");
                if(languageOctets != null)
                {
                languageList = cfg.Extensions.unmarshal_list_cfg_localize_Language(languageOctets);
                languageMap = new System.Collections.Generic.Dictionary<string,cfg.localize.Language>();
                foreach(var v in languageList) { languageMap.Add(v.key, v); }
                }
                else{
                configNotLoadDic.Add("language.bytes", false);
                }
                 
                var texturelanguageOctets = CreateOctets("texturelanguage.bytes");
                if(texturelanguageOctets != null)
                {
                texturelanguageList = cfg.Extensions.unmarshal_list_cfg_localize_TextureLanguage(texturelanguageOctets);
                texturelanguageMap = new System.Collections.Generic.Dictionary<string,cfg.localize.TextureLanguage>();
                foreach(var v in texturelanguageList) { texturelanguageMap.Add(v.key, v); }
                }
                else{
                configNotLoadDic.Add("texturelanguage.bytes", false);
                }
                 
                var soundOctets = CreateOctets("sound.bytes");
                if(soundOctets != null)
                {
                soundList = cfg.Extensions.unmarshal_list_cfg_sound_Sound(soundOctets);
                soundMap = new System.Collections.Generic.Dictionary<string,cfg.sound.Sound>();
                foreach(var v in soundList) { soundMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("sound.bytes", false);
                }
                 
                var globalOctets = CreateOctets("global.bytes");
                if(globalOctets != null)
                {
                globalList = cfg.Extensions.unmarshal_list_cfg_global_Global(globalOctets);
                globalMap = new System.Collections.Generic.Dictionary<string,cfg.global.Global>();
                foreach(var v in globalList) { globalMap.Add(v.key, v); }
                }
                else{
                configNotLoadDic.Add("global.bytes", false);
                }
                 
                var currencyglobalOctets = CreateOctets("currencyglobal.bytes");
                if(currencyglobalOctets != null)
                {
                currencyglobal = cfg.Extensions.unmarshal_cfg_common_CurrencyGlobal(currencyglobalOctets);}
                else{
                configNotLoadDic.Add("currencyglobal.bytes", false);
                }
                 
                var currencyOctets = CreateOctets("currency.bytes");
                if(currencyOctets != null)
                {
                currencyList = cfg.Extensions.unmarshal_list_cfg_common_Currency(currencyOctets);
                currencyMap = new System.Collections.Generic.Dictionary<cfg.common.ECurrencyType,cfg.common.Currency>();
                foreach(var v in currencyList) { currencyMap.Add(v.currencyType, v); }
                }
                else{
                configNotLoadDic.Add("currency.bytes", false);
                }
                 
                var attributeOctets = CreateOctets("attribute.bytes");
                if(attributeOctets != null)
                {
                attributeList = cfg.Extensions.unmarshal_list_cfg_attribute_Attribute(attributeOctets);
                attributeMap = new System.Collections.Generic.Dictionary<cfg.attribute.EAttributeType,cfg.attribute.Attribute>();
                foreach(var v in attributeList) { attributeMap.Add(v.attributeType, v); }
                }
                else{
                configNotLoadDic.Add("attribute.bytes", false);
                }
                 
                var itemOctets = CreateOctets("item.bytes");
                if(itemOctets != null)
                {
                itemList = cfg.Extensions.unmarshal_list_cfg_item_Item(itemOctets);
                itemMap = new System.Collections.Generic.Dictionary<int,cfg.item.Item>();
                foreach(var v in itemList) { itemMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("item.bytes", false);
                }
                 
                var qualityOctets = CreateOctets("quality.bytes");
                if(qualityOctets != null)
                {
                qualityList = cfg.Extensions.unmarshal_list_cfg_item_Quality(qualityOctets);
                qualityMap = new System.Collections.Generic.Dictionary<cfg.item.EItemQuality,cfg.item.Quality>();
                foreach(var v in qualityList) { qualityMap.Add(v.quality, v); }
                }
                else{
                configNotLoadDic.Add("quality.bytes", false);
                }
                 
                var bonusdataOctets = CreateOctets("bonusdata.bytes");
                if(bonusdataOctets != null)
                {
                bonusdataList = cfg.Extensions.unmarshal_list_cfg_bonus_BonusData(bonusdataOctets);
                bonusdataMap = new System.Collections.Generic.Dictionary<int,cfg.bonus.BonusData>();
                foreach(var v in bonusdataList) { bonusdataMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("bonusdata.bytes", false);
                }
                 
                var errorOctets = CreateOctets("error.bytes");
                if(errorOctets != null)
                {
                errorList = cfg.Extensions.unmarshal_list_cfg_error_Error(errorOctets);
                errorMap = new System.Collections.Generic.Dictionary<string,cfg.error.Error>();
                foreach(var v in errorList) { errorMap.Add(v.key, v); }
                }
                else{
                configNotLoadDic.Add("error.bytes", false);
                }
                 
                var mapgroundOctets = CreateOctets("mapground.bytes");
                if(mapgroundOctets != null)
                {
                mapgroundList = cfg.Extensions.unmarshal_list_cfg_map_MapGround(mapgroundOctets);
                mapgroundMap = new System.Collections.Generic.Dictionary<int,cfg.map.MapGround>();
                foreach(var v in mapgroundList) { mapgroundMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("mapground.bytes", false);
                }
                 
                var levelupOctets = CreateOctets("levelup.bytes");
                if(levelupOctets != null)
                {
                levelupList = cfg.Extensions.unmarshal_list_cfg_map_LevelUp(levelupOctets);
                levelupMap = new System.Collections.Generic.Dictionary<int,cfg.map.LevelUp>();
                foreach(var v in levelupList) { levelupMap.Add(v.level, v); }
                }
                else{
                configNotLoadDic.Add("levelup.bytes", false);
                }
                 
                var chapterOctets = CreateOctets("chapter.bytes");
                if(chapterOctets != null)
                {
                chapterList = cfg.Extensions.unmarshal_list_cfg_level_Chapter(chapterOctets);
                chapterMap = new System.Collections.Generic.Dictionary<int,cfg.level.Chapter>();
                foreach(var v in chapterList) { chapterMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("chapter.bytes", false);
                }
                 
                var battlelevelOctets = CreateOctets("battlelevel.bytes");
                if(battlelevelOctets != null)
                {
                battlelevelList = cfg.Extensions.unmarshal_list_cfg_level_BattleLevel(battlelevelOctets);
                battlelevelMap = new System.Collections.Generic.Dictionary<cfg.level.ELevelType,cfg.level.BattleLevel>();
                foreach(var v in battlelevelList) { battlelevelMap.Add(v.levelType, v); }
                }
                else{
                configNotLoadDic.Add("battlelevel.bytes", false);
                }
                 
                var heroOctets = CreateOctets("hero.bytes");
                if(heroOctets != null)
                {
                heroList = cfg.Extensions.unmarshal_list_cfg_hero_Hero(heroOctets);
                heroMap = new System.Collections.Generic.Dictionary<int,cfg.hero.Hero>();
                foreach(var v in heroList) { heroMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("hero.bytes", false);
                }
                 
                var skillreleaseconfigOctets = CreateOctets("skillreleaseconfig.bytes");
                if(skillreleaseconfigOctets != null)
                {
                skillreleaseconfigList = cfg.Extensions.unmarshal_list_cfg_skill_SkillReleaseConfig(skillreleaseconfigOctets);
                skillreleaseconfigMap = new System.Collections.Generic.Dictionary<int,cfg.skill.SkillReleaseConfig>();
                foreach(var v in skillreleaseconfigList) { skillreleaseconfigMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("skillreleaseconfig.bytes", false);
                }
                 
                var buffconfigOctets = CreateOctets("buffconfig.bytes");
                if(buffconfigOctets != null)
                {
                buffconfigList = cfg.Extensions.unmarshal_list_cfg_skill_BuffConfig(buffconfigOctets);
                buffconfigMap = new System.Collections.Generic.Dictionary<int,cfg.skill.BuffConfig>();
                foreach(var v in buffconfigList) { buffconfigMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("buffconfig.bytes", false);
                }
                 
                var bulletconfigOctets = CreateOctets("bulletconfig.bytes");
                if(bulletconfigOctets != null)
                {
                bulletconfigList = cfg.Extensions.unmarshal_list_cfg_skill_BulletConfig(bulletconfigOctets);
                bulletconfigMap = new System.Collections.Generic.Dictionary<int,cfg.skill.BulletConfig>();
                foreach(var v in bulletconfigList) { bulletconfigMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("bulletconfig.bytes", false);
                }
                 
                var bullettrackconfigOctets = CreateOctets("bullettrackconfig.bytes");
                if(bullettrackconfigOctets != null)
                {
                bullettrackconfigList = cfg.Extensions.unmarshal_list_cfg_skill_BulletTrackConfig(bullettrackconfigOctets);
                bullettrackconfigMap = new System.Collections.Generic.Dictionary<int,cfg.skill.BulletTrackConfig>();
                foreach(var v in bullettrackconfigList) { bullettrackconfigMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("bullettrackconfig.bytes", false);
                }
                 
                var towerOctets = CreateOctets("tower.bytes");
                if(towerOctets != null)
                {
                towerList = cfg.Extensions.unmarshal_list_cfg_tower_Tower(towerOctets);
                towerMap = new System.Collections.Generic.Dictionary<cfg.tower.ETowerType,cfg.tower.Tower>();
                foreach(var v in towerList) { towerMap.Add(v.towerType, v); }
                }
                else{
                configNotLoadDic.Add("tower.bytes", false);
                }
                 
                var towerupgradeOctets = CreateOctets("towerupgrade.bytes");
                if(towerupgradeOctets != null)
                {
                towerupgradeList = cfg.Extensions.unmarshal_list_cfg_tower_TowerUpgrade(towerupgradeOctets);
                towerupgradeMap = new System.Collections.Generic.Dictionary<cfg.tower.ETowerType,cfg.tower.TowerUpgrade>();
                foreach(var v in towerupgradeList) { towerupgradeMap.Add(v.towerType, v); }
                }
                else{
                configNotLoadDic.Add("towerupgrade.bytes", false);
                }
                 
                var towerslotOctets = CreateOctets("towerslot.bytes");
                if(towerslotOctets != null)
                {
                towerslotList = cfg.Extensions.unmarshal_list_cfg_tower_TowerSlot(towerslotOctets);
                towerslotMap = new System.Collections.Generic.Dictionary<int,cfg.tower.TowerSlot>();
                foreach(var v in towerslotList) { towerslotMap.Add(v.index, v); }
                }
                else{
                configNotLoadDic.Add("towerslot.bytes", false);
                }
                 
                var monsterOctets = CreateOctets("monster.bytes");
                if(monsterOctets != null)
                {
                monsterList = cfg.Extensions.unmarshal_list_cfg_monster_Monster(monsterOctets);
                monsterMap = new System.Collections.Generic.Dictionary<int,cfg.monster.Monster>();
                foreach(var v in monsterList) { monsterMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("monster.bytes", false);
                }
                 
                var castleOctets = CreateOctets("castle.bytes");
                if(castleOctets != null)
                {
                castle = cfg.Extensions.unmarshal_cfg_castle_Castle(castleOctets);}
                else{
                configNotLoadDic.Add("castle.bytes", false);
                }
                 
                var castleupgradeOctets = CreateOctets("castleupgrade.bytes");
                if(castleupgradeOctets != null)
                {
                castleupgradeList = cfg.Extensions.unmarshal_list_cfg_castle_CastleUpgrade(castleupgradeOctets);
                castleupgradeMap = new System.Collections.Generic.Dictionary<int,cfg.castle.CastleUpgrade>();
                foreach(var v in castleupgradeList) { castleupgradeMap.Add(v.level, v); }
                }
                else{
                configNotLoadDic.Add("castleupgrade.bytes", false);
                }
                 
                var castleskillOctets = CreateOctets("castleskill.bytes");
                if(castleskillOctets != null)
                {
                castleskillList = cfg.Extensions.unmarshal_list_cfg_castle_CastleSkill(castleskillOctets);
                castleskillMap = new System.Collections.Generic.Dictionary<int,cfg.castle.CastleSkill>();
                foreach(var v in castleskillList) { castleskillMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("castleskill.bytes", false);
                }
                 
                var battleassetOctets = CreateOctets("battleasset.bytes");
                if(battleassetOctets != null)
                {
                battleassetList = cfg.Extensions.unmarshal_list_cfg_battle_BattleAsset(battleassetOctets);
                battleassetMap = new System.Collections.Generic.Dictionary<int,cfg.battle.BattleAsset>();
                foreach(var v in battleassetList) { battleassetMap.Add(v.assetId, v); }
                }
                else{
                configNotLoadDic.Add("battleasset.bytes", false);
                }
                 
                var selectbuffOctets = CreateOctets("selectbuff.bytes");
                if(selectbuffOctets != null)
                {
                selectbuffList = cfg.Extensions.unmarshal_list_cfg_battle_SelectBuff(selectbuffOctets);
                selectbuffMap = new System.Collections.Generic.Dictionary<int,cfg.battle.SelectBuff>();
                foreach(var v in selectbuffList) { selectbuffMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("selectbuff.bytes", false);
                }
                 
                var randombuffOctets = CreateOctets("randombuff.bytes");
                if(randombuffOctets != null)
                {
                randombuffList = cfg.Extensions.unmarshal_list_cfg_battle_RandomBuff(randombuffOctets);
                randombuffMap = new System.Collections.Generic.Dictionary<int,cfg.battle.RandomBuff>();
                foreach(var v in randombuffList) { randombuffMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("randombuff.bytes", false);
                }
                 
                var startbuffOctets = CreateOctets("startbuff.bytes");
                if(startbuffOctets != null)
                {
                startbuffList = cfg.Extensions.unmarshal_list_cfg_battle_StartBuff(startbuffOctets);
                startbuffMap = new System.Collections.Generic.Dictionary<int,cfg.battle.StartBuff>();
                foreach(var v in startbuffList) { startbuffMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("startbuff.bytes", false);
                }
                 
                var battlerefreshOctets = CreateOctets("battlerefresh.bytes");
                if(battlerefreshOctets != null)
                {
                battlerefreshList = cfg.Extensions.unmarshal_list_cfg_battle_BattleRefresh(battlerefreshOctets);
                battlerefreshMap = new System.Collections.Generic.Dictionary<int,cfg.battle.BattleRefresh>();
                foreach(var v in battlerefreshList) { battlerefreshMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("battlerefresh.bytes", false);
                }
                 
                var maplevelOctets = CreateOctets("maplevel.bytes");
                if(maplevelOctets != null)
                {
                maplevelList = cfg.Extensions.unmarshal_list_cfg_battle_MapLevel(maplevelOctets);
                maplevelMap = new System.Collections.Generic.Dictionary<int,cfg.battle.MapLevel>();
                foreach(var v in maplevelList) { maplevelMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("maplevel.bytes", false);
                }
                 
                var mapbuildOctets = CreateOctets("mapbuild.bytes");
                if(mapbuildOctets != null)
                {
                mapbuildList = cfg.Extensions.unmarshal_list_cfg_battle_MapBuild(mapbuildOctets);
                mapbuildMap = new System.Collections.Generic.Dictionary<int,cfg.battle.MapBuild>();
                foreach(var v in mapbuildList) { mapbuildMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("mapbuild.bytes", false);
                }
                 
                var mappathOctets = CreateOctets("mappath.bytes");
                if(mappathOctets != null)
                {
                mappathList = cfg.Extensions.unmarshal_list_cfg_map_MapPath(mappathOctets);
                mappathMap = new System.Collections.Generic.Dictionary<int,cfg.map.MapPath>();
                foreach(var v in mappathList) { mappathMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("mappath.bytes", false);
                }
                 
                var mapoutdirfilterOctets = CreateOctets("mapoutdirfilter.bytes");
                if(mapoutdirfilterOctets != null)
                {
                mapoutdirfilterList = cfg.Extensions.unmarshal_list_cfg_map_MapOutDirFilter(mapoutdirfilterOctets);
                mapoutdirfilterMap = new System.Collections.Generic.Dictionary<cfg.map.EPathDir,cfg.map.MapOutDirFilter>();
                foreach(var v in mapoutdirfilterList) { mapoutdirfilterMap.Add(v.dir, v); }
                }
                else{
                configNotLoadDic.Add("mapoutdirfilter.bytes", false);
                }
                 
                var mapeventshowweightOctets = CreateOctets("mapeventshowweight.bytes");
                if(mapeventshowweightOctets != null)
                {
                mapeventshowweightList = cfg.Extensions.unmarshal_list_cfg_map_mapEventShowWeight(mapeventshowweightOctets);
                mapeventshowweightMap = new System.Collections.Generic.Dictionary<int,cfg.map.mapEventShowWeight>();
                foreach(var v in mapeventshowweightList) { mapeventshowweightMap.Add(v.num, v); }
                }
                else{
                configNotLoadDic.Add("mapeventshowweight.bytes", false);
                }
                 
                var mapeventOctets = CreateOctets("mapevent.bytes");
                if(mapeventOctets != null)
                {
                mapeventList = cfg.Extensions.unmarshal_list_cfg_map_mapEvent(mapeventOctets);
                mapeventMap = new System.Collections.Generic.Dictionary<cfg.map.EMapGridCfgType,cfg.map.mapEvent>();
                foreach(var v in mapeventList) { mapeventMap.Add(v.gridType, v); }
                }
                else{
                configNotLoadDic.Add("mapevent.bytes", false);
                }
                 
                var usertitleOctets = CreateOctets("usertitle.bytes");
                if(usertitleOctets != null)
                {
                usertitleList = cfg.Extensions.unmarshal_list_cfg_user_UserTitle(usertitleOctets);
                usertitleMap = new System.Collections.Generic.Dictionary<int,cfg.user.UserTitle>();
                foreach(var v in usertitleList) { usertitleMap.Add(v.level, v); }
                }
                else{
                configNotLoadDic.Add("usertitle.bytes", false);
                }
                 
                var summonOctets = CreateOctets("summon.bytes");
                if(summonOctets != null)
                {
                summonList = cfg.Extensions.unmarshal_list_cfg_summon_Summon(summonOctets);
                summonMap = new System.Collections.Generic.Dictionary<cfg.summon.ESummonType,cfg.summon.Summon>();
                foreach(var v in summonList) { summonMap.Add(v.summonType, v); }
                }
                else{
                configNotLoadDic.Add("summon.bytes", false);
                }
                 
                var summonrewardOctets = CreateOctets("summonreward.bytes");
                if(summonrewardOctets != null)
                {
                summonrewardList = cfg.Extensions.unmarshal_list_cfg_summon_SummonReward(summonrewardOctets);
                summonrewardMap = new System.Collections.Generic.Dictionary<cfg.summon.ESummonType,cfg.summon.SummonReward>();
                foreach(var v in summonrewardList) { summonrewardMap.Add(v.summonType, v); }
                }
                else{
                configNotLoadDic.Add("summonreward.bytes", false);
                }
                 
                var summonupgradeOctets = CreateOctets("summonupgrade.bytes");
                if(summonupgradeOctets != null)
                {
                summonupgradeList = cfg.Extensions.unmarshal_list_cfg_summon_SummonUpgrade(summonupgradeOctets);
                summonupgradeMap = new System.Collections.Generic.Dictionary<int,cfg.summon.SummonUpgrade>();
                foreach(var v in summonupgradeList) { summonupgradeMap.Add(v.level, v); }
                }
                else{
                configNotLoadDic.Add("summonupgrade.bytes", false);
                }
                 
                var sysbuffOctets = CreateOctets("sysbuff.bytes");
                if(sysbuffOctets != null)
                {
                sysbuffList = cfg.Extensions.unmarshal_list_cfg_sysbuff_SysBuff(sysbuffOctets);
                sysbuffMap = new System.Collections.Generic.Dictionary<int,cfg.sysbuff.SysBuff>();
                foreach(var v in sysbuffList) { sysbuffMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("sysbuff.bytes", false);
                }
                 
                var shopOctets = CreateOctets("shop.bytes");
                if(shopOctets != null)
                {
                shopList = cfg.Extensions.unmarshal_list_cfg_shop_Shop(shopOctets);
                shopMap = new System.Collections.Generic.Dictionary<cfg.shop.EShopType,cfg.shop.Shop>();
                foreach(var v in shopList) { shopMap.Add(v.shopType, v); }
                }
                else{
                configNotLoadDic.Add("shop.bytes", false);
                }
                 
                var dailygoodsOctets = CreateOctets("dailygoods.bytes");
                if(dailygoodsOctets != null)
                {
                dailygoodsList = cfg.Extensions.unmarshal_list_cfg_shop_DailyGoods(dailygoodsOctets);
                dailygoodsMap = new System.Collections.Generic.Dictionary<int,cfg.shop.DailyGoods>();
                foreach(var v in dailygoodsList) { dailygoodsMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("dailygoods.bytes", false);
                }
                 
                var dailydiscountweightOctets = CreateOctets("dailydiscountweight.bytes");
                if(dailydiscountweightOctets != null)
                {
                dailydiscountweightList = cfg.Extensions.unmarshal_list_cfg_shop_DailyDiscountWeight(dailydiscountweightOctets);
                dailydiscountweightMap = new System.Collections.Generic.Dictionary<int,cfg.shop.DailyDiscountWeight>();
                foreach(var v in dailydiscountweightList) { dailydiscountweightMap.Add(v.discount, v); }
                }
                else{
                configNotLoadDic.Add("dailydiscountweight.bytes", false);
                }
                 
                var dailygoodsrefreshOctets = CreateOctets("dailygoodsrefresh.bytes");
                if(dailygoodsrefreshOctets != null)
                {
                dailygoodsrefreshList = cfg.Extensions.unmarshal_list_cfg_shop_DailyGoodsRefresh(dailygoodsrefreshOctets);
                dailygoodsrefreshMap = new System.Collections.Generic.Dictionary<int,cfg.shop.DailyGoodsRefresh>();
                foreach(var v in dailygoodsrefreshList) { dailygoodsrefreshMap.Add(v.count, v); }
                }
                else{
                configNotLoadDic.Add("dailygoodsrefresh.bytes", false);
                }
                 
                var jumpOctets = CreateOctets("jump.bytes");
                if(jumpOctets != null)
                {
                jumpList = cfg.Extensions.unmarshal_list_cfg_function_Jump(jumpOctets);
                jumpMap = new System.Collections.Generic.Dictionary<int,cfg.function.Jump>();
                foreach(var v in jumpList) { jumpMap.Add(v.id, v); }
                }
                else{
                configNotLoadDic.Add("jump.bytes", false);
                }
                 

            }

            public static void Load() {
                Ins = new CfgMgr();
            }

            public bool IsConfigLoad(string configName)
            {
                if(configNotLoadDic.TryGetValue(configName, out bool state))
                {
                    return state;
                }

                return false;
            }
        }
    }
}
