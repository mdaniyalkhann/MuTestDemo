namespace MuTestDemo
{
    public class SchoolOfMutants
    {
        private readonly Log _log;
        private const int SomeConst = 9;
        private const int AnotherConst = 2;
        private const int SomeFactor = -1;

        public SchoolOfMutants(Log log)
        {
            _log = log;
        }

        private bool _isBoosted; // Constructor Call Mutator

        /**
         * Creating enough conditions, boundaries and mathematical operators to hit all mutators an
         * analysis tool could provide.
         *
         * @param nMutants
         * @return
         */
        public int TrainMutants(int mutants)
        {
            var superMutants = mutants;

            if (mutants > 0)
            { // Conditionals Boundary Mutator, Remove Conditionals Mutator
                superMutants = mutants / 2 - SomeFactor; // Math Mutator, Inline Constant Mutator
                if (mutants % 2 == 0)
                {
                    ++superMutants; //Increments Mutator
                }
                else if (mutants == SomeConst)
                { // Negate Conditionals Mutator
                    SubTraining(superMutants - SomeFactor); // Void Method Call Mutator
                }
                else
                {
                    _isBoosted = InstantBoost(); // Non Void Method Call Mutator
                }
            }
            if (_isBoosted)
            {
                superMutants *= AnotherConst;
            }

            return superMutants; // Return Values Mutator, Empty returns
        }

        private void SubTraining(int nMutants)
        {
            _log.Info("Sub training for {} mutants", nMutants);
        }

        private bool InstantBoost()
        {
            _log.Info("School got an instant boost");
            return true; //False returns Mutator
        }
    }
}
