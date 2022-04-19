### Problem Statement
• In the CypherCrescent Software Academy, there are two possible Programmes one can join – Frontend and Backend. Both programmes hold classes on Tuesday and Thursday. However, the Backend holds an additional class on Monday, while the Frontend holds an additional class on Wednesday.

• Each programme has a collection of Students, and each Student is associated with only one programme. Programmes also have a collection of facilitators, and every facilittaor is associated with just one programme. Both facilitator and student are humans all humans and have names, can attend class, ask questions, and answer questions. They all attend classes in the same way but ask and answer questions differently. Students can ask questions to facilitators and fellow students, while facilitators ask questions to students alone. Both students and facilitators can also answer questions. Both give explanations when they answer, but a facilitator gives additional resources after explanations.

• Your task is to model the CypherCrescent Software Academy in OOP terms. Note that the attend class functionality has a weekday parameter; your program must first check to know which programme the human belongs then check if the weekday parameter is among the possible weekdays for that programme. If it is not among the possible weekdays, it should display a message saying “No class today”, otherwise it should say “The host will let you in shortly”, and after 5 seconds display another message “You’re in!”.

• Hint: Days of the week should be an enum.

• To test your code, create an array of 10 humans (4 facilitators & 6 students) – 5 frontend and 5 backend. Using one loop, each of the 10 humans should attempt to attend classes on Monday and Wednesday.
![CCL_ACADEMY](https://user-images.githubusercontent.com/65626254/164048299-43c65118-1877-48d1-a2d6-3aa89748b899.png)
