
using System;

namespace HyperPascal
{
    public class Program
    {
        /*public static string Input;

        public static char Look;
        public static int CurrentIndex = 0;

        public static void GetChar()
        {
            if (CurrentIndex >= Input.Length)
            {
                return;
            }

            Look = Input[CurrentIndex++];
        }

        public static void Error(string error)
        {
            Console.WriteLine($"Error: {error}");
        }

        public static void Abort(string error)
        {
            Error(error);
            Console.ReadKey();
        }

        public static void Expected(string expected)
        {
            Abort($"{expected} expected");
        }

        public static void Match(char c)
        {
            if (Look == c)
            {
                GetChar();
            }
            else
            {
                Expected($"'{c}'");
            }
        }

        public static bool IsAlpha(char c)
        {
            return char.IsLetter(c);
        }

        public static bool IsNumber(char c)
        {
            return char.IsNumber(c);
        }

        public static char GetName()
        {
            char c = Look;

            if (!IsAlpha(c))
            {
                Expected("Name");
                return new char();
            }

            GetChar();

            return char.ToUpper(c);
        }

        public static char GetNumber()
        {
            char c = Look;

            if (!IsNumber(c))
            {
                Expected("Number");
                return new char();
            }

            GetChar();

            return c;
        }

        public static void Emit(string output)
        {
            Console.Write($"\t{output}");
        }

        public static void EmitLine(string output)
        {
            Emit(output);
            Console.WriteLine();
        }

        public static void Init()
        {
            GetChar();
        }


        public static void Term()
        {
            EmitLine($"MOVE #{GetNumber()}, D0");
        }

        public static void Expression()
        {
            Term();
            EmitLine($"MOVE D0,D1");

            switch (Look)
            {
                case '+':
                    Add();
                    break;

                case '-':
                    Subtract();
                    break;

                default:
                    Expected("AddOp");
                    break;
            }
        }
        
        private static void Add()
        {
            EmitLine($"ADD D1,D0");
        }

        private static void Subtract()
        {
            throw new NotImplementedException();
        }*/

        public static void Main(string[] args)
        {
            
        }
    }

    /*public class Token
    {
        public Token(string type, object value)
        {
            Type = type;
            Value = value;
        }

        public string Type { get; private set; }

        public object Value { get; private set; }

        public override string ToString()
        {
            return $"Token({Type}, {Value})";
        }
    }

    public class Interpreter
    {
        private int currentIndex;
        private char currentChar;

        public Interpreter(string input)
        {
            Input = input;
            CurrentToken = null;

            currentIndex = 0;
            currentChar = Input[currentIndex];
        }
        
        public string Input { get; private set; }

        public Token CurrentToken { get; set; }

        public void Run()
        {
            CurrentToken = GetNextToken();
        }

        private Token GetNextToken()
        {
            while (HasMoreInput())
            {
                if (char.IsWhiteSpace(currentChar))
                {
                    SkipWhiteSpace();
                }

                if (char.IsDigit(currentChar))
                {
                    return new Token("INTEGER", GetInteger());
                }

                if (currentChar == '+')
                {
                    Advance();
                    return new Token("PLUS", "+");
                }

                if (currentChar == '-')
                {
                    Advance();
                    return new Token("MINUS", "-");
                }
            }

            return null;
        }

        private int GetInteger()
        {
            string result = "";

            while (HasMoreInput() && char.IsDigit(currentChar))
            {
                result += currentChar;
                Advance();
            }

            return int.Parse(result);
        }

        private bool HasMoreInput()
        {
            return currentIndex <= Input.Length;
        }

        private void SkipWhiteSpace()
        {
            while (HasMoreInput() && char.IsWhiteSpace(currentChar))
            {
                Advance();
            }
        }

        private void Advance()
        {
            currentIndex++;

            if (HasMoreInput())
            {
                currentChar = Input[currentIndex];
            }
        }
    }*/

    public abstract class Parser
    {
        protected static SymbolTable symbolTable;
        protected Scanner scanner;
        protected object intermediateCode;

        static Parser()
        {
            symbolTable = null;
        }

        protected Parser(Scanner scanner)
        {
            this.scanner = scanner;
            this.intermediateCode = null;
        }

        public abstract void Parse();

        public abstract int ErrorCount { get; }

        public Token CurrentToken
        {
            get { return scanner.CurrentToken; }   
        }

        public Token NextToken
        {
            get { return scanner.NextToken; }
        }
    }

    public class Token
    { }

    public class Scanner
    {
        public Token CurrentToken { get; }

        public Token NextToken { get; }
    }

    public class SymbolTable
    { }
}
