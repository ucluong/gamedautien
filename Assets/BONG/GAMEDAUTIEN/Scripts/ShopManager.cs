using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.DefenseBasic
{
    public class ShopManager : MonoBehaviour
    {
        public ShopItem[] items;

        // Start is called before the first frame update
        void Start()
        {
            Init();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void Init()
        {
            if (items == null || items.Length <= 0) return;

            for (int i = 0; i < items.Length; i++)
            {
                var item = items[i];
                string dataKey = Const.PLAYRE_PREFIX_PREF + i; // player_0 , player_1,player_2

                if (item != null)
                {
                    if (i == 0)
                        Pref.SetBool(dataKey ,true);

                    else
                    {
                        if (!PlayerPrefs.HasKey(dataKey))
                            Pref.SetBool(dataKey, false);
                    }


                }
                
            }
        }
    }

}