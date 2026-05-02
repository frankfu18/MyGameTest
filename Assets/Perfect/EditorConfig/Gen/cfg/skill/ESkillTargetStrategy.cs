namespace editor
{
namespace cfg.skill
{
public enum ESkillTargetStrategy
{
     DistanceMin = 1, 
      HpMin = 2, 
      Random = 3, 
      InAtkRadius = 4, 
      InBlockDistanceMin = 5, 
      InBlockAll = 6, 
      InPathDistanceMin = 7, 
      ALL = 8, 
      TerrainGrid = 9, 
      RandomEnemyTerrainGrid = 10, 
      NearEnemyTerrainGrid = 11, 
      Ignore = 99, 
     
}
}
}