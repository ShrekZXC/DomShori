using DomShori.Interface;
using DomShori.Models;
using System;
using System.Collections.Generic;

namespace DomShori.Mocks
{
    public class MockCurtains : IAllCurtains
    {
        private readonly ICurtainsCategory _categoryCurtains = new MockCategory();
        public IEnumerable<Curtain> curtains 
        {
            get
            {
                return new List<Curtain>
                {
                    new Curtain{
                        name = "Готовые шторы на шторной ленте ",
                        img = "Res/first.jpg",
                        priceWithTulle = 2500,
                        priceWithoutTulle = 2500,
                        isFavorit = true,
                        available = true,
                        size =2.7,
                        textill = "блэкаут мрамор",
                        category = _categoryCurtains.AllCategories.First()
                    },
                    new Curtain{
                        name = "Готовые шторы на шторной ленте ",
                        img="Res/second.jpg",
                        priceWithTulle = 2500,
                        priceWithoutTulle = 2500,
                        isFavorit=true,
                        available = true,
                        size = 2.7,
                        textill = "блэкаут мрамор",
                        category = _categoryCurtains.AllCategories.First()
                    },
                    new Curtain{
                        name = "Готовые шторы на шторной ленте ",
                        img = "Res/third.jpg",
                        priceWithTulle = 2500,
                        priceWithoutTulle = 2500,
                        isFavorit = true,
                        available = true,
                        size =2.7,
                        textill = "блэкаут мрамор",
                        category = _categoryCurtains.AllCategories.First()
                    },
                    new Curtain{
                        name = "Готовые шторы на шторной ленте ",
                        img = "Res/five.jpg",
                        priceWithTulle = 2500,
                        priceWithoutTulle = 2500,
                        isFavorit = true,
                        available = true,
                        size =2.7,
                        textill = "блэкаут мрамор",
                        category = _categoryCurtains.AllCategories.First()
                    },
                    new Curtain{
                        name = "Готовые шторы на шторной ленте ",
                        img = "Res/six.jpg",
                        priceWithTulle = 2500,
                        priceWithoutTulle = 2500,
                        isFavorit = true,
                        available = true,
                        size =2.7,
                        textill = "блэкаут мрамор",
                        category = _categoryCurtains.AllCategories.First()
                    }
                };
            }
        }

        public IEnumerable<Curtain> getFavCurtains { get ; set ; }

        public Curtain GetObjCurtain(int curtainId)
        {
            throw new NotImplementedException();
        }
    }
}
