using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.DefenseBasic
{
    public class GUIManager : Dialog
    {
        public GameObject HomeGUI;
        public GameObject GameGui;
        public Dialog GameoverDialog;
        public Text maiCoinTxt;
        public Text gameplayCoinTxt;

        private void Start()
        {
            
        }

        public void ShowGameGUI(bool isShow)
        {
            if (GameGui)
                GameGui.SetActive(isShow);

            if (HomeGUI)
                HomeGUI.SetActive(isShow);
        }

        public void UpdateMaiCoi()
        {
            if (maiCoinTxt)
                maiCoinTxt.text = Pref.coins.ToString();
        }

        public void updaGameplayCois()
        {
            if (gameplayCoinTxt)
                gameplayCoinTxt.text = Pref.coins.ToString();
        }
    }


}