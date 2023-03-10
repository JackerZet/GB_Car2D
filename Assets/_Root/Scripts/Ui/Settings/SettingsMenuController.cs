using Profile;
using Tool;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Ui.Settings
{
    internal class SettingsMenuController : BaseController
    {
        private readonly ResourcePath _resourcePath = new("SettingsMenu");
        private readonly ProfilePlayer _profilePlayer;
        private readonly SettingsMenuView _view;


        public SettingsMenuController(Transform placeForUi, ProfilePlayer profilePlayer)
        {
            _profilePlayer = profilePlayer;
            _view = LoadView(placeForUi);
            _view.Init(BackGame);
        }

        private SettingsMenuView LoadView(Transform placeForUi)
        {
            GameObject prefab = ResourcesLoader.LoadPrefab(_resourcePath);
            GameObject objectView = Object.Instantiate(prefab, placeForUi, false);
            AddGameObject(objectView);

            return objectView.GetComponent<SettingsMenuView>();
        }

        private void BackGame() =>
            _profilePlayer.CurrentState.Value = GameState.Start;
       
    }
}
