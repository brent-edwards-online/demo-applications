using System.Collections.Generic;
using System;

namespace AutoComplete_Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            ITrie trie = new Trie.Trie();

            string data = "Gravida nisl aliquam taciti a nulla vestibulum ad a consectetur scelerisque primis vestibulum condimentum enim fermentum sodales scelerisque parturient laoreet vivamus parturient massa eget. A vivamus habitasse vivamus fringilla ullamcorper odio ullamcorper ullamcorper a nec mi per massa urna a varius vivamus a iaculis a. Dui rhoncus curabitur a a adipiscing inceptos cum a condimentum dictumst adipiscing consectetur sed dolor non hac tempus a vestibulum convallis condimentum himenaeos. Id ultricies hac mi praesent placerat scelerisque magna a lectus diam tortor a tristique vivamus vestibulum primis dapibus sociosqu.";
            data += "Lacus aenean mauris euismod torquent scelerisque habitant a leo elementum parturient convallis eros phasellus et volutpat parturient viverra neque at taciti class parturient metus cras facilisi.Augue sociosqu fermentum at quisque praesent parturient a sapien curabitur et pulvinar eget euismod eu class suscipit est blandit ullamcorper urna ac eu torquent est.Dictum at dictum in parturient litora arcu consectetur ridiculus condimentum adipiscing felis tempor sed nisi suspendisse pretium a inceptos sagittis molestie integer. Arcu a at suspendisse vestibulum ullamcorper vestibulum a arcu netus a ac quam dapibus sem fringilla neque leo semper fusce non leo scelerisque quis quis.Euismod vehicula massa condimentum faucibus sed est tristique ullamcorper adipiscing dis adipiscing blandit a eu ullamcorper fames parturient nisi tristique feugiat penatibus. Eros lacinia feugiat consectetur vivamus lacus eu curae a ut fermentum mi pharetra aliquam dolor porta proin pulvinar cum hac a molestie rutrum.";
            data += "Est in nunc eget quam vestibulum diam odio mi at ad aptent condimentum a imperdiet ad at ipsum curae tortor semper imperdiet ac a molestie inceptos vehicula.Parturient a nullam nec a in suscipit vestibulum eget lacinia venenatis est dui a sed potenti accumsan ultrices nullam ac enim adipiscing posuere sed urna adipiscing a gravida natoque.Scelerisque vestibulum scelerisque a vestibulum ante hendrerit nibh potenti inceptos cursus leo dui fringilla ac.Odio iaculis aliquet vulputate elit viverra tristique mus volutpat tristique a imperdiet lobortis proin ullamcorper a a non eros.Neque id vestibulum dapibus curae et a sociosqu nisl montes consectetur integer adipiscing leo ut accumsan ipsum posuere. Suspendisse a aenean at a a dictumst metus condimentum sodales ullamcorper mollis in commodo a diam morbi vel vestibulum potenti orci natoque parturient consectetur a volutpat mollis tristique sociosqu.";
            data += "Eu litora justo at inceptos a nostra molestie in a mi parturient magnis ullamcorper neque porta hac. Bibendum condimentum a scelerisque nisi accumsan id consectetur integer consectetur curabitur vestibulum vestibulum vivamus scelerisque adipiscing condimentum.Adipiscing eleifend aliquam vestibulum odio ultrices placerat adipiscing cubilia sit parturient morbi tristique curabitur facilisis adipiscing a a rhoncus netus purus orci sit a at in accumsan parturient. Nascetur sagittis imperdiet volutpat sem parturient consectetur vitae adipiscing habitant lectus scelerisque pulvinar eros nec adipiscing hendrerit himenaeos euismod purus ac senectus curabitur platea id condimentum torquent.";
            data += "A luctus condimentum suspendisse donec cursus tortor velit sociosqu adipiscing et id nulla sagittis ad nec eleifend aptent nec a.Felis vestibulum scelerisque purus vivamus lobortis scelerisque scelerisque adipiscing commodo urna nisl vestibulum a mi lorem sed ridiculus risus ac integer adipiscing sociosqu morbi.";

            var dictionary = data.Split(new []{' '});

           trie.Create(dictionary);

            bool keepGoing = true;
            while(keepGoing == true)
            {
                var prefix = Console.ReadLine();

                if (prefix == "x")
                {
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("Prefix: " + prefix);
                    var result = trie.AutoComplete(prefix);
                    foreach (var r in result)
                    {
                        Console.WriteLine(r);
                    }
                    Console.WriteLine("****\n");
                }
            }
            

            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}
