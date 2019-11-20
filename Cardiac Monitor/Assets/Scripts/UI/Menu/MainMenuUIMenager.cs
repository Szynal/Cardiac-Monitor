using System.Collections.Generic;
using Assets.Scripts.UI.Menu.Animations;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Menu
{
    public class MainMenuUIMenager : MonoBehaviour
    {

        [SerializeField] private MainMenuUIAnimations uiAnimations;
        [SerializeField] private Transform graphy;
        [Header("Buttons")]
        [SerializeField] private List<Button> entryMenuButtons;
        [SerializeField] private List<Button> exitButtons;
        private bool exitMode;

        private void Start()
        {
            uiAnimations = GetComponent<MainMenuUIAnimations>();
            ChooseCharacterSlot_ButtonClick(0);
            exitMode = false;
        }

        #region Init

        public MainMenuUIMenager(List<Button> entryMenuButtons, Transform typesPanel, MainMenuUIAnimations uiAnimations)
        {
            this.entryMenuButtons = entryMenuButtons;
            this.uiAnimations = uiAnimations;
        }

        #endregion

        #region UI Button

        [UsedImplicitly]
        public void NewGame_ButtonClick()
        {
            if (exitMode) return;
            uiAnimations?.NewGameUIAnimation();
        }

        [UsedImplicitly]
        public void Continue_ButtonClick()
        {
            if (exitMode) return;
            uiAnimations?.ContinueUIAnimation();
        }

        [UsedImplicitly]
        public void Options_ButtonClick()
        {
            if (exitMode)
            {
                graphy.gameObject.SetActive(false);
                return;
            }

            uiAnimations?.OptionsUIAnimation();
            graphy.gameObject.SetActive(true);
        }

        [UsedImplicitly]
        public void Credits_ButtonClick()
        {
            //TODO new SCENE CREDITS
            // Application.LoadLevel("Credits");
        }

        [UsedImplicitly]
        public void Exit_ButtonClick()
        {
            exitMode = !exitMode;
            if (exitMode)
            {
                uiAnimations.ExitUIAnimation(false);
                foreach (var button in entryMenuButtons) button.interactable = false;
                foreach (var button in exitButtons) button.interactable = true;
            }
            else
            {
                uiAnimations.ExitUIAnimation(true);
                foreach (var button in entryMenuButtons) button.interactable = true;
                foreach (var button in exitButtons) button.interactable = false;

            }
        }

        [UsedImplicitly]
        public void ConfirmExit_ButtonClick()
        {
            Quit();
        }

        [UsedImplicitly]
        public void DeclineExit_ButtonClick()
        {
            uiAnimations?.ExitUIAnimation(true);
            foreach (var button in entryMenuButtons) button.interactable = true;
            exitMode = false;
        }

        [UsedImplicitly]
        public void CreatePanel_ReturnButtonClick()
        {
            if (exitMode) return;
            uiAnimations.CreatePanel_ReturnUIAnimation();
        }

        [UsedImplicitly]
        public void ContinuePanel_ReturnButtonClick()
        {
            if (exitMode) return;
            uiAnimations.ContinuePanel_ReturnUIAnimation();
        }

        [UsedImplicitly]
        public void OptionsPanel_ReturnButtonClick()
        {
            if (exitMode) return;
            uiAnimations.OptionsPanel_ReturnUIAnimation();
            graphy.gameObject.SetActive(false);
        }

        [UsedImplicitly]
        public void Help_ButtonClick()
        {
        }

        [UsedImplicitly]
        public void PreviousPlanet_ButtonClick()
        {
        }

        [UsedImplicitly]
        public void NextPlanet_ButtonClick()
        {
        }

        [UsedImplicitly]
        public void CreateNewInstance_ButtonClick()
        {
            SceneManager.LoadScene("Desert");
        }

        [UsedImplicitly]
        public void ToggleDynamicGrass_ButtonClick()
        {
        }

        [UsedImplicitly]
        public void ChooseCharacterSlot_ButtonClick(int indexSlot)
        {
        }

        [UsedImplicitly]
        public void LoadCharacter_ButtonClick()
        {
        }

        [UsedImplicitly]
        public void DeleteCharacter_ButtonClick()
        {
        }

        #endregion

        private void SetCharacterClassInRootController()
        {
        }

        private void SetProfessionText(GameObject currentProfession, GameObject nextProfession)
        {
            currentProfession.SetActive(false);
            nextProfession.SetActive(true);
        }


        private static void GetChilds(Transform parent, ref List<GameObject> gameObjects)
        {
            /*
                        for (int index = 0; index < parent.childCount; index++)
                            gameObjects?.Add(parent.GetChild(index).gameObject);
                    */
        }

        public static void Quit()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
#else
         Application.Quit();
#endif
        }
    }
}