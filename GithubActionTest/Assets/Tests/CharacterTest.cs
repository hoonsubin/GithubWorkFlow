using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CharacterTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CharacterDamaged()
        {
            GameObject characterObj = new GameObject();
            var character = characterObj.AddComponent<Character>();

            character.OnDamage(3);

            Assert.AreEqual(character.HP, 5);
        }
    }
}
