using UnityEngine;

namespace AbstractFactoryGunFire.Unit.Archer
{
    public abstract class Archer : Unit
    {
        [SerializeField] protected float _rangeDistance;

        public void Init(float rangeDistance)
        {
            _rangeDistance = rangeDistance;
        }
        public abstract void Shoot();
    }
}
