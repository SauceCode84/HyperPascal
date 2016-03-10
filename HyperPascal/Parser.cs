namespace HyperPascal
{
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
}