using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class BookController : MonoBehaviour
{
    public Book book;
   

   

    [Header("Book Open Image")]
    public Image BookOpenImage;
    public List<Sprite> BookOpenSprites;

    [Header("Room Background")]
    public Image RoomImages;
    public List<Sprite> RoomSprites;

   

  

    public List<Sprite> days1;
    public List<Sprite> days2;
    public List<Sprite> days3;
    public List<Sprite> days4;
    public List<Sprite> days5;
    public List<Sprite> days6;
    public List<Sprite> days7;
    public List<Sprite> days8;
    public List<Sprite> days9;
    public List<Sprite> days10;
    public List<Sprite> days11;
    public List<Sprite> days12;
    public List<Sprite> days13;
    public List<Sprite> days14;
    public List<Sprite> days15;
    public List<Sprite> days16;
    public List<Sprite> days17;
    public List<Sprite> days18;
    public List<Sprite> days19;
    public List<Sprite> days20;
    public List<Sprite> days21;
    public List<Sprite> days22;
    public List<Sprite> days23;
    public List<Sprite> days24;
    public List<Sprite> days25;
    public List<Sprite> days26;
    public List<Sprite> days27;
    public List<Sprite> days28;
    public List<Sprite> days29;
    public List<Sprite> days30;

   
    public void SetBook()
    {
        book.hand.SetActive(true);
        book.bookTranform.anchoredPosition = new Vector2(-365, 0);
        book.gamebtn.SetActive(false);
        book.RightHotSpot.SetActive(true);
        book.OpenBook.enabled = false;
        book.right.interactable = true;
        book.left.interactable = false;
       

        if (GameManger.gameManger.activeGameIndeks == 0)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days1.Count; i++)
            {
                book.bookPages.Add(days1[i]); // Kitap icerigi dolduruldu
            }


            

            //1. ADIM
            BookOpenImage.sprite = BookOpenSprites[0]; //0 -> Kiz kitabi acik hali

            //2. ADIM
            RoomImages.sprite = RoomSprites[0]; //0 -> Kiz odasi

            //3. ADIM
            book.currentPage = 0; // Kitabi kapat = currentPage sifirla

            //4. ADIM
            book.UpdateSprites(); // Sayfayi guncelledikten sonra spritelari guncelle

            //5. ADIM
            book.RightNext.sprite = book.bookPages[0]; //0 -> Kitap kapali hali listede en bastaki gelecek.

        }
        else if (GameManger.gameManger.activeGameIndeks == 1)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days2.Count; i++)
            {
                book.bookPages.Add(days2[i]); 
            }

           
            BookOpenImage.sprite = BookOpenSprites[1]; 
            RoomImages.sprite = RoomSprites[1]; 
            book.currentPage = 0; 
            book.UpdateSprites(); 
            book.RightNext.sprite = book.bookPages[0]; 
        }

        else if (GameManger.gameManger.activeGameIndeks == 2)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days3.Count; i++)
            {
                book.bookPages.Add(days3[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 3)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days4.Count; i++)
            {
                book.bookPages.Add(days4[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 5)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days6.Count; i++)
            {
                book.bookPages.Add(days6[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 7)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days8.Count; i++)
            {
                book.bookPages.Add(days8[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 9)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days10.Count; i++)
            {
                book.bookPages.Add(days10[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 11)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days12.Count; i++)
            {
                book.bookPages.Add(days12[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 13)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days14.Count; i++)
            {
                book.bookPages.Add(days14[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 15)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days16.Count; i++)
            {
                book.bookPages.Add(days16[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 17)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days18.Count; i++)
            {
                book.bookPages.Add(days18[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 19)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days20.Count; i++)
            {
                book.bookPages.Add(days20[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }
        else if (GameManger.gameManger.activeGameIndeks == 21)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days22.Count; i++)
            {
                book.bookPages.Add(days22[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 23)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days24.Count; i++)
            {
                book.bookPages.Add(days24[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 25)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days26.Count; i++)
            {
                book.bookPages.Add(days26[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }
        else if (GameManger.gameManger.activeGameIndeks == 27)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days28.Count; i++)
            {
                book.bookPages.Add(days28[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }
        else if (GameManger.gameManger.activeGameIndeks == 29)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days30.Count; i++)
            {
                book.bookPages.Add(days30[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[1];
            RoomImages.sprite = RoomSprites[1];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 4)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days5.Count; i++)
            {
                book.bookPages.Add(days5[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 6)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days7.Count; i++)
            {
                book.bookPages.Add(days7[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 8)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days9.Count; i++)
            {
                book.bookPages.Add(days9[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 10)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days11.Count; i++)
            {
                book.bookPages.Add(days11[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 12)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days13.Count; i++)
            {
                book.bookPages.Add(days13[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 14)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days15.Count; i++)
            {
                book.bookPages.Add(days15[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 16)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days17.Count; i++)
            {
                book.bookPages.Add(days17[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 18)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days19.Count; i++)
            {
                book.bookPages.Add(days19[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }
        else if (GameManger.gameManger.activeGameIndeks == 20)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days21.Count; i++)
            {
                book.bookPages.Add(days21[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

        else if (GameManger.gameManger.activeGameIndeks == 22)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days23.Count; i++)
            {
                book.bookPages.Add(days23[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }


        else if (GameManger.gameManger.activeGameIndeks == 24)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days25.Count; i++)
            {
                book.bookPages.Add(days25[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }
        else if (GameManger.gameManger.activeGameIndeks == 26)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days27.Count; i++)
            {
                book.bookPages.Add(days27[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }
        else if (GameManger.gameManger.activeGameIndeks == 28)
        {
            book.bookPages = new List<Sprite>();
            for (int i = 0; i < days29.Count; i++)
            {
                book.bookPages.Add(days29[i]);
            }


            BookOpenImage.sprite = BookOpenSprites[0];
            RoomImages.sprite = RoomSprites[0];
            book.currentPage = 0;
            book.UpdateSprites();
            book.RightNext.sprite = book.bookPages[0];
        }

      
    }

    public void Return()
    {
        SetBook();
    }

    public void Hand()
    {
        book.hand.SetActive(false);
    }
   
}