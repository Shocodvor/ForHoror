          using AbstractFactoryGunFire.Unit;
          using AbstractFactoryGunFire.Unit.Archer;
          using AbstractFactoryGunFire.Unit.Knight;
          using UnityEngine;
          using System.Collections;
          using System.Collections.Generic;

          namespace AbstractFactoryGunFire
          {
          public class RedUnitsFactory : UnitsFactory

          {

          public GameObject Machinehun;
          public Transform charactersSpawn,charactersSpawn2;


          public override Knight CreateKnight()
          {

          charactersSpawn  = GameObject.FindGameObjectWithTag("MGun2").GetComponent<Transform> ();
          var prefab = Resources.Load<GameObject>("Gun3");
          var go = GameObject.Instantiate(prefab);
          var knight = go.GetComponent<RedKnight>();
          go.transform.SetParent(charactersSpawn);
          go.transform.localPosition = new Vector3(0, 0, 0);

          knight.Init(3.3f);
          return knight;

          }
          public override Mage CreateMage()
          {
          charactersSpawn  = GameObject.FindGameObjectWithTag("MGun").GetComponent<Transform> ();
          var prefab = Resources.Load<GameObject>("Gun");
          var go = GameObject.Instantiate(prefab);
          var mage = go.GetComponent<RedMage>();
          go.transform.SetParent(charactersSpawn);
          go.transform.localPosition = new Vector3(0, 0, 0);
          mage.Init(1.0f, 5.0f);
          return mage;
          }


          public override Archer CreateArcher()
          {
          charactersSpawn  = GameObject.FindGameObjectWithTag("MGun").GetComponent<Transform> ();
          var prefab = Resources.Load<GameObject>("3Missles");
          var go = GameObject.Instantiate(prefab);
          var archer = go.GetComponent<RedArcher>();
          go.transform.SetParent(charactersSpawn);
          go.transform.localPosition = new Vector3(0, 0, 0);
          archer.Init(1.0f, 1.0f);
          return archer;
          }

          public override Archer DroneCreator()
          {
          charactersSpawn  = GameObject.FindGameObjectWithTag("MGun2").GetComponent<Transform> ();


          var prefab = Resources.Load<GameObject>("Drone");

          var go = GameObject.Instantiate(prefab);
          var archer = go.GetComponent<RedArcher>();

          go.transform.SetParent(charactersSpawn);
          go.transform.localPosition = new Vector3(0, 0, 0);

          charactersSpawn2  = GameObject.FindGameObjectWithTag("DroneSpawn").GetComponent<Transform> ();
          var prefab2 = Resources.Load<GameObject>("Drones");
          var go2 = GameObject.Instantiate(prefab2);
          go2.transform.SetParent(charactersSpawn2);
          go2.transform.localPosition = new Vector3(0, 0, 0);
          var archer2 = go.GetComponent<RedArcher>();

          archer.Init(1.0f, 1.0f);




          return archer;
          }

          }
          }
