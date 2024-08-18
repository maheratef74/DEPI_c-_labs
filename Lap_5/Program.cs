namespace Lap_5;

class Program
{
    static void Main(string[] args)
    {
        #region q from 2 >> 5
            //q2
            q_1_to_5 q = new q_1_to_5();
            q.one_dimensional_array();
          
            // q3
            q.sum_of_all_elements_in_a_one_dimensional();
          
          
            //q4
            q.reverse_the_elements_of_a_one_dimensional_array();

            
           // q5
           q.two_dimensional_array();
        #endregion

        #region q from 6 >> 10

        Q_6_to_10 qq = new Q_6_to_10();
        
        
        //q_6
        qq.sum_two_dimensional_array();
          
        //q_7
        qq.transpose();
        
        //q_8
        qq.print_even();
        
        // q_9
        qq.do_while();
        
        // q_10
        qq.implicit_casting_from_int_to_double();
        #endregion

        #region Q 11 >> 15
    
        Q_11_to_15 qqq = new Q_11_to_15();
        
        // q_11
        qqq.explicit_casting_from_double_to_int();
        
        //q_12
        qqq.string_to_an_integer(); 
        
        // q_13
        qqq.cast_dog_to_animal();
        
        //q_14
        qqq.boxing();
        
        //q_15
        qqq.boxing_does_not_affect();
        #endregion

        #region Q 16 >> 22

        Q_16_to_22 qqqq = new Q_16_to_22();
        
        // q_16
        qqqq.print_boxing_value();
        
        //q_17
        qqqq.print_unboxing_value();
        
        //q_18
        qqqq.print_unboxing_value_and_check();
        
        // q_19
        qqqq.print_unboxing_value_handel_excption();
        
        //q_20
        qqqq.check_null_integer();
        
        //q_21
        qqqq.check_null_integer_using();
        
        //q_22
        qqqq.check_null_reference();
        #endregion
    }
    
}