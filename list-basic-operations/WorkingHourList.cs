using System;
using System.Collections.Generic;
using System.Text;

namespace list_basic_operations
{
    public class WorkingHourList
    {
        public WorkingHourNode Head;
        public WorkingHourNode Programarcaptura;

        public void Add(WorkingHour workingHourToAdd, int insert, int after)
        {
            WorkingHourNode newWorkingHourNode = new WorkingHourNode();
            newWorkingHourNode.WorkingHour = workingHourToAdd;
            if (workingHourToAdd.Id==insert || workingHourToAdd.Id == after)
            {

                if (workingHourToAdd.Id == insert)

                {
                    Programarcaptura = newWorkingHourNode;
                }
                else
                {
                    if (Head == null)  //Es el nodo padre
                    {
                        Head = newWorkingHourNode;
                        WorkingHourNode Last = Head;
                        Last = Last.Next;
                        Last.Next = Programarcaptura;

                    }
                    else
                    {
                        WorkingHourNode Last = Head;
                        while (Last.Next != null)
                        {
                            Last = Last.Next;
                        }
                        Last.Next = newWorkingHourNode;
                        Last = Last.Next;
                        Last.Next = Programarcaptura;
                    }
                }
            }
            else
            {
                if (Head == null)  //Es el nodo padre
                {
                    Head = newWorkingHourNode;

                }
                else
                {
                    WorkingHourNode Last = Head;
                    while (Last.Next != null)
                    {
                        Last = Last.Next;
                    }
                    Last.Next = newWorkingHourNode;
                }
            }
        }
               
        public void Print()
        {
            WorkingHourNode tmp = Head;
            while (tmp != null)
            {
                Console.WriteLine($"StartTime: {tmp.WorkingHour.StartTime} - FinalTime: {tmp.WorkingHour.FinalTime} - Location: {tmp.WorkingHour.Location} - Id: {tmp.WorkingHour.Id}");
                tmp = tmp.Next;
            }
        }


    }
}
