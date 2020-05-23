#include <msp430.h>
#include <msp430fr5739.h>
#include <stdio.h>

/**
 * main.c
 */



//MECH423 FINAL PROJECT MASTER TUNING MOTOR CODE
#define FALSE 0
#define TRUE 0

unsigned int stepperState = 0; //1-4 states
unsigned int stepperSpeed = 700;
unsigned int stepperSpeed2 = 1000;

unsigned int stepperCount = 0;
unsigned int stepperReset = 0; //How many steps before reset
//unsigned int stepperReset = 1600; //How many steps before reset
unsigned int stepperEnable = 1;

unsigned int stepperSelect = 0; //0-tuning motor, 1-plucking motor

unsigned int stepperCount2 = 0;
unsigned int stepperReset2 = 400; //How many steps before reset

unsigned long int noteNumber = 0;


//Code for initializing the queue and defining queue functions
typedef struct{
    unsigned int front;
    unsigned int num;
    unsigned int capacity;
    unsigned int* arr;
} Queue;

void initQueue(Queue* q, unsigned int numValues) {
    q->front = 0;
    q->num= 0;
    q->capacity = numValues; // or some other value
    q->arr= (unsigned int*) malloc(q->capacity * sizeof(unsigned int));
}

unsigned int isEmpty(Queue* q) {
    if(q->num== 0)
        return TRUE;
    else
        return FALSE;
}

unsigned int isFull(Queue* q) {
    if(q->num== q->capacity)
        return TRUE;
    else
        return FALSE;
}

unsigned int enqueue(Queue* q, int val) {
    if(isFull(q))
        return FALSE;
    else{
        q->arr[(q->front + q->num) % q->capacity] = val;
        q->num++;
        return TRUE;
    }
}

unsigned int dequeue(Queue* q) {
    int val;
    if(isEmpty(q))
        return FALSE;
    else{
        val = q->arr[q->front];
        q->arr[q->front] = -1;
        q->front = (q->front + 1) % q->capacity;
        q->num--;
        return  val;
    }
}

unsigned int sizeQueue(Queue *q){
    return q->num;
}

void inline printQueue(Queue *q){
    unsigned int index = 0;
    int arrVal = 0;

    while(q->arr[index] != NULL){
        arrVal = q->arr[index];
        if (arrVal < 0)
            index++;
        else{
            while (!(UCA1IFG & UCTXIFG));
            UCA1TXBUF = arrVal;
            index++;
        }
    }
}

void printFullQueueError(void){
    /*int j;

    for (j = 0; fullQueueErrorMsg[j] != 0; j++){
        while (!(UCA1IFG & UCTXIFG));
        UCA1TXBUF = fullQueueErrorMsg[j];
    }*/
}

//TUNING STEPPER MOTOR FUNCTIONS
void moveStepperToPosition(int positionNum){
    //while(stepperCount != stepperReset){
        TB0CCTL1 = OUTMOD_3 + CCIE;

}

void sendPulseToSlave(void){
    //This timer B2 sends a pulse to P2.7 of the slave board every 1 second to initiate the plucking motor
    //Set up P3.6 to output a pulse
    /*
    P3DIR |= BIT6;
    P3SEL1 &= ~BIT6;
    P3SEL0 |= BIT6;
    TB2CCR0 = 6000-1;                         // PWM Period
    TB2CCTL1 = OUTMOD_7;                      // CCR1 reset/set
    TB2CCR1 = 500;                            // CCR1 PWM duty cycle
    TB2CTL |= TBSSEL_2 + MC_1 + TBCLR + ID__8;         // SMCLK, up mode, clear TAR (clears the timer B count)
    P3DIR &= ~BIT6;
    */
    P3OUT ^= BIT6;
}

void moveTuningMotor(int noteNum){
    /* C1 = 1
     * C1# = 2
     * D1 = 3
     * D1# = 4
     * E1 = 5
     * F1 = 6
     * F1# =7
     * G1 =8
     * G1# =9
     * A1 =10
     * A1# =11
     * B1 =12
     * C2 =13
     * C2# =14
     * D2 =15
     * D2# =16
     * E2 =17
     * F2 =18
     * F2# =19
     * G2 =20
     * G2# =21
     * A2 =22
     * A2# =23
     * B2 =24
     * C3 =25
     * C3# =26
     * D3 =27
     * D3# =28
     * E3 =29
     * F3 =30
     * F3# =31
     * G3 =32
     * G3# =33
     * A3 =34
     * A3# =35
     * B3 =36
     * C4 =37
     * C4# =38
     * D4 = 39
     * D4# =40
     * E4 =41
     * F4 =42
     * F4# =43
     * G4 =44
     * G4# =45
     * A4 =46
     * A4# =47
     * B4 =48
     * C5 =49
     * C5# =50
     * D5 =51
     * D5# =52
     * E5 =53
     * F5 =54
     * F5# =55
     * G5 =56
     * G5# =57
     * A5 =58
     * A5# =59
     * B5 =60
     */

    //playnote routine
    stepperReset = noteNum;
    moveStepperToPosition(noteNumber);

    //TB0CCTL1 &= ~CCIE;
    //enable the interrupt to run the stepper motor at pre-defined intervals
   // TB0CCTL1 = OUTMOD_3 + CCIE;
    //while(stepperCount != stepperReset);

    //moveStepperToPosition(noteNumber);
    //_delay_cycles(1000);
    //sendPulseToSlave();
}


Queue myq;

int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer

    initQueue(&myq, 1); // initialize the queue with size 1

    CSCTL0 = 0xA500;                        // Write password to modify CS registers
    CSCTL1 = DCOFSEL0 + DCOFSEL1;           // DCO = 8 MHz
    CSCTL2 = SELM0 + SELM1 + SELA0 + SELA1 + SELS0 + SELS1;               //remove divider to take SMCLK to 8Mhz

    //CONFIGURE UART PORTS
    P2SEL0 &= ~(BIT5 + BIT6);
    P2SEL1 |= BIT5 + BIT6;
    //Configure UART 1
    UCA1CTLW0 = UCSSEL0;                                        // Run the UART using ACLK
    //UCA0MCTLW = UCOS16 + UCBRF_1 + 0x4900;                    // Baud Rate = 9600; UCOS16 = 1; UCBR0 = 52; UCBRF0 = 1; UCBRS0 = 0x4900
    UCA1MCTLW = UCOS16 + UCBRF_10 + 0xF700;                     // Baud Rate = 57600; UCOS16 = 1; UCBR0 = 52; UCBRF0 = 10; UCBRS0 = 0xF700
    UCA1BRW = 52;
    UCA1IE |= UCRXIE;                                           // Enable UART Rx interrupt


    P2DIR &= ~BIT7;                     //Make 1.7 input
    P2REN |= BIT7;                      //Enable 1.7s Resistors
    P2OUT |= BIT7;                      //Enable 1.7 Resistor to pullup
    P2IES |= BIT7;                      //Interrupt 1.7 from falling edge
    P2IE |= BIT7;                       //Enable interrupts


    /*
    //Stepper Motor Stuff DRV8841
    P1DIR |= 0b00110000;
    P3DIR |= 0b00110000;
    P1SEL1 &= ~(0b00110000);
    P1SEL0 &= ~(0b00110000);
    P3SEL1 &= ~(0b00110000);
    P3SEL0 &= ~(0b00110000);
    */

    //A4988 Driver
    P3DIR |= 0b01001111;
    P3SEL1 = 0;
    P3SEL0 = 0;
    P1DIR |= 0b00110000;
    P1SEL0 = 0b00000000;
    P1SEL1 = 0;
    P1OUT = 0b00100000;


    //Setup Interrupt which manages the velocity of the stepper

    TB0CTL = TBSSEL_2 + ID__1 + MC_1;   //Set clock to read from SMCLK, divide by 1, operate in up mode
    TB0CCR0 = stepperSpeed;
    TB0CCR1 = stepperSpeed *0.5;
    TB0CCTL1 = OUTMOD_3;
    TB0CCTL1 &= ~CCIE;
    //TB0CCTL1 = OUTMOD_3;


    __enable_interrupt();             //enable Global interrupts

    while(1){
        //while (!(UCA1IFG & UCTXIFG));
        //UCA1TXBUF = 10;

        if(sizeQueue(&myq) >= 1 && sizeQueue(&myq) <= 3){
            noteNumber = dequeue(&myq);
            noteNumber = noteNumber* 200;
            moveTuningMotor(noteNumber);
        }
        _delay_cycles(100000);
    }

    return 0;
}

#pragma vector = PORT2_VECTOR;
__interrupt void PORT2_ISR(void)
{
    P2IFG &= ~BIT0;              //reset interrupt
    stepperEnable = 1;
    TB0CCTL1 = OUTMOD_3 + CCIE;
   // moveTuningMotor(noteNumber);
    P2OUT ^= 0b00000001;
}


#pragma vector = TIMER0_B1_VECTOR
__interrupt void TIMER0_B1_ISR(void){

    if(stepperCount < stepperReset){
        P3OUT &= ~BIT1;
        stepperCount++;
        P3OUT ^= BIT0;
    }

    else if(stepperCount > stepperReset){
        P3OUT |= BIT1;
        stepperCount--;
        P3OUT ^= BIT0;
    }

    if (stepperCount == stepperReset){
        //stepperCount = 0;

        //TB0CCTL1 = OUTMOD_3;
        stepperSelect = 1;
    }
    //now plucking motor starts


    if (stepperSelect == 1){
            TB0CCR0 = stepperSpeed2;
            TB0CCR1 = stepperSpeed2*0.5;
            stepperCount2++;

            if (stepperCount2 >= stepperReset2){
                stepperCount2 = 0;
                stepperSelect = 0;
                stepperEnable = 0;
                TB0CCTL1 = OUTMOD_3;
                TB0CCR0 = stepperSpeed;
                TB0CCR1 = stepperSpeed*0.5;
            }
            else{
                P3OUT ^= BIT2;
            }
    }

    TB0CCTL1 &= ~(0x1); //clear the timer B0 flag
}

// Receive data from C#
#pragma vector = USCI_A1_VECTOR
__interrupt void USCI_A1_ISR(void)
{
    // Get the new byte from the Rx buffer
    unsigned int RxByte = 0;                   // can also be int type
    RxByte = UCA1RXBUF;                         // Get the new byte from the Rx buffer

    if (!isFull(&myq)){
       enqueue(&myq, RxByte);
    }
    else{
       printFullQueueError();
    }

    if(isFull(&myq)){
        printQueue(&myq);
    }
}

