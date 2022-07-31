using System;

namespace AdapterPattern {
    /*适配器模式适用于：
     * 1.系统需要使用现有的类，而此类的接口不符合系统的需要
     * 2.想要建立一个重复使用的类，用于与彼此之间没有太大关联的一些类，包括一些可能
     * 在将来引进的类一起工作，这些源类不一定有很复杂的接口
     * 3.（对对象适配器而言）在设计里需要改变对哦个已有的子类的接口，如果使用
     * 类的适配器模式，就要针对每一个子类做一个适配器，二者不太实际
     * 
     
     
     */
    class Client {
        static void Main(string[] args) {
            ITarget t = new Adapter();
            t.Request();
            Console.ReadKey();
        }
    }
}
