using UnityEngine;

namespace AbstractFactoryGunFire.Unit.Knight
{
    public class RedKnight : Knight
    {
        [SerializeField] private float _redKnightKoef;


        public void Init(float redKnightKoef)
        {
            _redKnightKoef = redKnightKoef;
            Destroy(gameObject);
        }
        public override void Parry()
        {

        }
    }
}
