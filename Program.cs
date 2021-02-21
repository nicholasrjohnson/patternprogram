using System;
using System.Collections.Generic;

namespace patternprogram
{    class Program
    {
    public static HashSet<char> vowels = new HashSet<char>();
        static void Main(string[] args)
        {
            int matches = 0;
            bool match = true;
            vowels.Add( 'a' );
            vowels.Add( 'e' );
            vowels.Add( 'o' );
            vowels.Add( 'i' );
            vowels.Add( 'o' );

            char[] letters = new char[args[0].Length];
            letters = args[0].ToLower().ToCharArray();
    
            char[] pattern = new char[ args[1].Length ];    
            pattern = args[1].ToCharArray();

            for( int i = 0; i < letters.Length - pattern.Length + 1; i++ ) {
                for( int j = 0; j < pattern.Length; j++ ) {
                    if( pattern[ j ]  == '0' ) {
                        if( vowels.Contains( letters[ i+ j ] ) ) {
                            match = false;    
                        }
                    } else {
                        if ( !vowels.Contains( letters[ i + j ] ) ) {
                            match = false;
                        }
                    }
                }
                if( match == true ) {
                    matches++;
                }
                match = true;
            }
            Console.WriteLine( matches );
        }
    }
}
