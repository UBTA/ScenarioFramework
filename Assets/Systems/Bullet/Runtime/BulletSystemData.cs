using EblanDev.ScenarioCore.GameFramework.Data;
using UnityEngine;

namespace EblanDev.ScenarioCore.Systems.BulletSystemUnit
{
    [CreateAssetMenu(fileName = "BulletData", menuName = "ScenarioFramework/Systems/BulletData", order = 1)]
    public class BulletSystemData : DataClear
    {
        [SerializeField] private BulletInstance[] bullets;

        public BulletInstance Bullet(int BulletID)
        {
            foreach (var bullet in bullets)
            {
                if (bullet.BulletID == BulletID)
                {
                    return bullet;
                }
            }
            
            return bullets[0];
        }
    }
}