using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using System;
using UnityEngine.UI;

public class HeartContainerTest
{
    public class TheReplenishMethod
    {
        protected Image Target;
        private Heart _heart;

        [SetUp]
        public void BeforeEveryTest()
        {
            Target = new GameObject().AddComponent<Image>();
            _heart = new Heart(Target);
        }

        [Test]
        public void _0_Sets_Image_With_0_Fill_To_0_Fill()
        {
            Target.fillAmount = 0;

            var heartContainer = new HeartContainer(new List<Heart> { _heart });

            heartContainer.Replenish(0);

            Assert.AreEqual(0, Target.fillAmount);
        }

        [Test]
        public void _1_Sets_Image_With_0_Fill_To_25_Percent_Fill()
        {
            Target.fillAmount = 0;

            var heartContainer = new HeartContainer(new List<Heart> { _heart });

            heartContainer.Replenish(1);

            Assert.AreEqual(0.25f, Target.fillAmount);
        }

        [Test]
        public void _2_Empty_Hearts_Are_Replenished()
        {
            Target.fillAmount = 0;
            var image = new GameObject().AddComponent<Image>();
            image.fillAmount = 1;
            var heartContainer = new HeartContainer(new List<Heart> { new Heart(image), new Heart(Target) });

            heartContainer.Replenish(1);

            Assert.AreEqual(0.25f, Target.fillAmount);
        }

        [Test]
        public void _3_Hearts_Are_Replenished_In_Order()
        {
            Target.fillAmount = 0;
            var image = new GameObject().AddComponent<Image>();
            image.fillAmount = 0;
            var heartContainer = new HeartContainer(new List<Heart> { new Heart(image), new Heart(Target) });

            heartContainer.Replenish(1);

            Assert.AreEqual(0, Target.fillAmount);
        }


        public class HeartContainer
        {
            private readonly List<Heart> _hearts;

            public HeartContainer(List<Heart> hearts)
            {
                _hearts = hearts;
            }

            public void Replenish(int numberOfHeartPieces)
            {
                var numberOfHeartPiecesRemaining = numberOfHeartPieces;
                foreach(var heart in _hearts)
                {
                    numberOfHeartPiecesRemaining -= Heart.HeartPiecesPerHeart - heart.CurrentNumberOfHeartPieces;
                    heart.Replenish(numberOfHeartPieces);
                    if (numberOfHeartPiecesRemaining <= 0) break;
                }
            }
        }
    }

}
