﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    internal class RandomEnviroment
    {
        private Random random;
        private List<List<int>> matrixQ;
        private List<List<double>> matrixTransitions = new List<List<double>>();
        private int state = 0; //текущее состояние среды
        private int nextState = 0; //следующее состояние среды
        private double eventTime = 0;
        private int processedEventsCount = 0;

        public RandomEnviroment(Random random, List<List<int>> matrixQ)
        {
            this.random = random;
            this.matrixQ = matrixQ;
            calculateMatrixTransitions();
        }

        private void calculateMatrixTransitions()
        {
            matrixTransitions.Clear();
            //Метод на основе матрицы Q вычисляет вероятности переходов.
            for (int i = 0; i < matrixQ.Count; i++)
            {
                matrixTransitions.Add(new List<double>());
                for (int j = 0; j < matrixQ[i].Count; j++)
                {
                    matrixTransitions.ElementAt(i).Insert(j, 0.0);
                    double ver = (double) -matrixQ[i][j] / matrixQ[i][i];
                    if (i != j) matrixTransitions.ElementAt(i).Insert(j, ver);
                    ImitationForm.Log("Matrix value: -" + matrixQ[i][j] + " / " + matrixQ[i][i] + " = " + ver);
                }
                ImitationForm.Log("");
            }
        }

        internal double getEventTime()
        {
            if (eventTime == 0)
            {
                generateNextEvent(); //генерируем nextState
                generateNextEvent(); //генерируем state
                processedEventsCount = 0;
            }
            return eventTime;
        }

        internal void generateNextEvent()
        {
            state = nextState;
            eventTime = eventTime + Math.Log(random.NextDouble()) / matrixQ[state][state];

            nextState = 0;
            double A = random.NextDouble() - matrixTransitions[state][nextState];
            while (A > 0)
            {
                nextState++;
                A -= matrixTransitions[state][nextState];
            }
        }

        internal int getProcessedRequestsCount()
        {
            return processedEventsCount;
        }

        internal int getState()
        {
            return state;
        }

        internal void generateNextState() {
            generateNextEvent();
            processedEventsCount++; //увеличиваем число обработанных событий
        }
    }
}