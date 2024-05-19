            using UnityEngine;
            using UnityEngine.UI;
            using System.Collections;


            namespace AbstractFactoryGunFire
            {
            public class MainS : MonoBehaviour
            {

            public Transform parent;
            [SerializeField] private Button _knightButton;
            [SerializeField] private Button _mageButton;
            [SerializeField] private Button _archerButton;
            [SerializeField] private Button _clearButton;

            [SerializeField] private GridLayoutGroup _unitGrid;

            [SerializeField] private Toggle _redToggle;
            [SerializeField] private Toggle _blueToggle;
            [SerializeField] private Toggle _greenToggle;

            private UnitsFactory _currentFactory;

            private void Awake()
            {
            // Задаём значение фабрики по умолчанию
            _currentFactory = new RedUnitsFactory();

            InitButtons();
            InitToggles();

            }



            public void RedNight ()

            {
            _currentFactory = new RedUnitsFactory();
            var knight = _currentFactory.CreateKnight();
            }

            public void RedMage ()

            {
            _currentFactory = new RedUnitsFactory();
            var mage = _currentFactory.CreateMage();

            }


            public void RedAtcher()

            {


            _currentFactory = new RedUnitsFactory();
            var archer = _currentFactory.CreateArcher();



            }

            public void DroneCreator()

            {


            _currentFactory = new RedUnitsFactory();
            var archer = _currentFactory.DroneCreator();



            }




            private void InitButtons()
            {
            _knightButton.onClick.AddListener((() =>
            {
            var knight = _currentFactory.CreateKnight();
            knight.transform.SetParent(_unitGrid.transform, false);
            }));

            _mageButton.onClick.AddListener((() =>
            {
            var mage = _currentFactory.CreateMage();
            mage.transform.SetParent(_unitGrid.transform, false);
            }));

            _archerButton.onClick.AddListener((() =>
            {
            var archer = _currentFactory.CreateArcher();
            archer.transform.SetParent(_unitGrid.transform, false);
            }));

            // Чистим грид
            _clearButton.onClick.AddListener((() =>
            {
            foreach (Transform child in _unitGrid.transform)
            {
                Destroy(child.gameObject);
            }
            }));
            }

            private void InitToggles()
            {
            _redToggle.onValueChanged.AddListener((val =>
            {
            if (val)
            {
                _currentFactory = new RedUnitsFactory();
            }
            }));

            // _blueToggle.onValueChanged.AddListener((val =>
            // {
            //     if (val)
            //     {
            //         _currentFactory = new BlueUnitsFactory();
            //     }
            // }));
            //
            // _greenToggle.onValueChanged.AddListener((val =>
            // {
            //     if (val)
            //     {
            //         _currentFactory = new GreenUnitsFactory();
            //     }
            // }));
            }


            }
            }
