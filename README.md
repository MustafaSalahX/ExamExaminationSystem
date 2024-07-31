##Discription !!
Your organization needs an Examination system according to the
following business case:
1. Design a Class to represent the Question Object, Question is
consisting of:
a. Header of the question
b. Body of the question
c. Mark

2. System has two types of exams (Final and Practical)
3. We want the application to accept different Question Types:
For Final Exam:
a. True or False
b. MCQ (Choose one answer)

For Practical Exam:
a. MCQ

Note: We need to define a Base Question class and every type as
an inherited one.
4. We need to define a class for the answers (AnswerId, AnswerText).
5. Question is associated with an Array of answers and its right
answer (Answers [ ] AnswerList) .

6. Design a Base class Exam describe the common attributes
concerning the exam:
a. Time of exam
b. Number of Questions
c. Show Exam Functionality that its implementations will be
different for each exam based on its type.

7. Every Exam object is Associated to a Subject.

Note: The Subject is a class that contains the following members:

a. Subject Id.
b. Subject Name.
c. Exam of the subject.
d. We need to implement functionality to create the exam of
the subject.

8- Practical Exam Shows the right answer after finishing the Exam.
9- Final Exam Shows the Questions, Answers and Grade.
10- In the Main you need to declare a subject object to create one type
of exam.
Note: Implement Icloneable, IComparable, consider overriding ToString,
use constructor chaining (If needed).
