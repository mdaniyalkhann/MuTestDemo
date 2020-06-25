# Mutation Coverage

Using an empty test that only assumes no exception is thrown.

1. Default config: using DEFAULT mutators: https://github.com/trilogy-group/cf-utqe-dotnet-mutator/blob/master/MuTest.Core/Mutators/Mutators.md
* Arithmetic Operators AOR
* Logical Connectors LCR
* Relational Operators ROR
* Assignment statements ASR
* String Literals SLR
* Void Method Calls VMCR

```ruby

MutatorWise Summary

String
Coverage: Mutation(0/2[0.00%])
Relational
Coverage: Mutation(4/5[80.00%])
Arithmetic
Coverage: Mutation(4/5[80.00%])
Assignment
Coverage: Mutation(2/2[100.00%])

```

profile `default` 71.43% coverage 10/14 @13.413s

2. All mutators
* Arithmetic Operators AOR
* Logical Connectors LCR
* Relational Operators ROR
* Boolean Literals BLR
* Assignment statements ASR
* Unary Operators UOR
* Linq Methods LMR
* String Literals SLR
* Method Calls MCR
* Statement Blocks SBR

```ruby
MutatorWise Summary
String
Coverage: Mutation(0/2[0.00%])
Boolean
Coverage: Mutation(1/1[100.00%])
Block
Coverage: Mutation(5/7[71.43%])
Relational
Coverage: Mutation(4/5[80.00%])
Negate
Coverage: Mutation(4/4[100.00%])
Arithmetic
Coverage: Mutation(3/4[75.00%])
MethodCall
Coverage: Mutation(1/1[100.00%])
Unary
Coverage: Mutation(1/1[100.00%])
Assignment
Coverage: Mutation(1/1[100.00%])
```

profile `all` 76.92% coverage 20/26 @28.99s

# Google's mutators

From this [research](https://static.googleusercontent.com/media/research.google.com/en//pubs/archive/46584.pdf) 
google uses a standard of 4 mutators to verify a tests value. These are:
* AOR Arithmetic operator replacement
* LCR Logical connector replacement
* ROR Relational operator replacement
* UOI Unary operator insertion
* SBR Statement block removal stmt

```ruby
MutatorWise Summary

Block
Coverage: Mutation(5/7[71.43%])
Relational
Coverage: Mutation(4/5[80.00%])
Arithmetic
Coverage: Mutation(3/4[75.00%])
Unary
Coverage: Mutation(1/1[100.00%])
```

profile `google` 76.47% coverage 13/17 @17.66s
