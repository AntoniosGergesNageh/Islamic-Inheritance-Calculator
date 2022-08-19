/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace almarith_project
{
    internal class Class1
    {
        Form1 form1 = new Form1();
        // Initialize the shares that we make the calc by it 
        public double sons_shares  ;
        protected double daughters_shares  ;
        protected double mother_share ;
        protected double father_share ;
        protected double brother_share ;
        protected double sister_share ;
        protected double husband_share ;
        protected double wives_share ;
        protected double individual_share ;
        protected double one_third_PRS ;
        protected double half_PRS ;
        protected double rem_aft_dau_share ;
        protected double x_share ;
        protected double rem_share ;

        protected int total_share = 1000;
        protected int num_of_sons = 1;
        protected int num_of_daugthers = 0;
        protected int father = 1;
        protected int mother = 0;
        protected int num_of_bro = 0;
        protected int num_of_sis = 0;
        protected int husband = 1;
        protected int bequest_share = 0;
        protected double rem_aft_hus = 0;
        protected double total_PRS;
        protected int num_of_wives;
        protected double rem_aft_wif;
        protected double half = .5, asixth = 1 / 6, one_third = 1 / 3, one_eighth = 1 / 8, afourth = 1 / 4, two_thirds = 2 / 3;



        public Class1(int total_share, int num_of_sons, int num_of_daugthers, int father, int mother, int num_of_bro, int num_of_sis, int husband)
        {
            this.total_share = total_share;
            this.num_of_sons = num_of_sons;
            this.num_of_daugthers = num_of_daugthers;
            this.father = father;
            this.mother = mother;
            this.num_of_bro = num_of_bro;
            this.num_of_sis = num_of_sis;
            this.husband = husband;




            if (num_of_sons > 0)
            {

                if (num_of_sons > 0)
                {

                    husband_share = (husband == 1 ? afourth * total_PRS : 0);
                    mother_share = (mother == 1 ? asixth * total_PRS : 0);
                    father_share = (father == 1 ? asixth * total_PRS : 0);

                    x_share = total_PRS - husband_share - mother_share - father_share;
                    // sons shares
                    sons_shares = num_of_sons * (2 * (x_share / (2 * num_of_sons + num_of_daugthers)));
                    // daughters shares
                    daughters_shares = (num_of_daugthers > 0 ? num_of_daugthers * (x_share / (2 * num_of_sons + num_of_daugthers)) : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers >= 2)
                {
                    daughters_shares = 2 * (total_PRS / 3);
                    rem_aft_dau_share = total_PRS - daughters_shares;
                    husband_share = (husband == 1 ? afourth * rem_aft_dau_share : 0);
                    mother_share = (mother == 1 ? asixth * rem_aft_dau_share : 0);
                    father_share = (father == 1 ? asixth * rem_aft_dau_share : 0);
                    brother_share = (num_of_bro == 1 ? afourth * rem_aft_dau_share : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 1)
                {
                    daughters_shares = total_PRS / 2;
                    husband_share = (husband == 1 ? afourth * total_PRS : 0);
                    rem_aft_dau_share = total_PRS - daughters_shares;
                    mother_share = (mother == 1 ? asixth * rem_aft_dau_share : 0);
                    father_share = (father == 1 ? asixth * rem_aft_dau_share : 0);
                    brother_share = (num_of_bro == 1 ? afourth * rem_aft_dau_share : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && num_of_bro == 0 && num_of_sis == 0)
                {
                    mother_share = (mother == 1 ? one_third * total_PRS : 0);
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    father_share = total_PRS - (mother_share + husband_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && (num_of_bro + num_of_sis) >= 2)
                {
                    mother_share = asixth * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);

                    one_third_PRS = one_third * total_PRS;
                    brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                    mother_share += total_PRS - (mother_share + husband_share + brother_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 1 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = asixth * total_PRS;
                    mother_share += total_PRS - (mother_share + husband_share + brother_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 0 && num_of_sis == 1)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? (1 / 2) * total_PRS : 0);
                    sister_share = asixth * total_PRS;
                    mother_share += total_PRS - (mother_share + husband_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis == 1)
                {
                    husband_share = (husband_share == 1 ? half * total_PRS : 0);
                    sister_share = half * total_PRS;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro >= 1 && num_of_sis == 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = total_PRS - husband_share;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis >= 2)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    rem_aft_hus = total_PRS - husband_share;

                    sister_share = two_thirds * rem_aft_hus;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro > 0 && num_of_sis > 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    rem_aft_hus = total_PRS - husband_share;

                    brother_share = num_of_bro * (2 * (rem_aft_hus / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (rem_aft_hus / (2 * num_of_bro + num_of_sis));
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 0 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    mother_share += total_PRS - (mother_share + husband_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis == 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && (num_of_bro + num_of_sis) >= 2)
                {
                    mother_share = asixth * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    one_third_PRS = one_third * total_PRS;
                    brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                    father_share = total_PRS - (mother_share + husband_share + brother_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 1 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = asixth * total_PRS;
                    father_share = total_PRS - (mother_share + husband_share + brother_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && (num_of_bro + num_of_sis) >= 2)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    one_third_PRS = one_third * total_PRS;
                    brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                    father_share = total_PRS - (mother_share + husband_share + brother_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 0 && num_of_sis == 1)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    sister_share = asixth * total_PRS;
                    father_share = total_PRS - (mother_share + husband_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis == 1)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    sister_share = half * total_PRS;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro >= 1 && num_of_sis == 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = total_PRS - husband_share;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 1 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? (1 / 2) * total_PRS : 0);
                    brother_share = asixth * total_PRS;
                    father_share += total_PRS - (mother_share + husband_share + brother_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 0 && num_of_sis == 1)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    sister_share = asixth * total_PRS;
                    father_share += total_PRS - (mother_share + husband_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && num_of_bro == 1 && num_of_sis == 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = asixth * total_PRS;
                    father_share += total_PRS - (husband_share + brother_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && num_of_bro == 0 && num_of_sis == 1)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    sister_share = asixth * total_PRS;
                    father_share += total_PRS - (husband_share + sister_share);
                }

                rem_share = total_PRS - (sons_shares + daughters_shares + mother_share + father_share + husband_share + brother_share + sister_share);

                //Console.WriteLine(" The rem share = " + rem_share + " sons will have " + sons_shares);


                form1.sonstake.Text = "efdfj";









            }
        }

            public void run_programe_1()
        {

            total_PRS = total_share - bequest_share;
            double rem_aft_hus = 0;







            //Determine if there are children's shares
            if (num_of_sons > 0)
            {

                if (num_of_sons > 0)
                {

                    husband_share = (husband == 1 ? afourth * total_PRS : 0);
                    mother_share = (mother == 1 ? asixth * total_PRS : 0);
                    father_share = (father == 1 ? asixth * total_PRS : 0);

                    x_share = total_PRS - husband_share - mother_share - father_share;
                    // sons shares
                    sons_shares = num_of_sons * (2 * (x_share / (2 * num_of_sons + num_of_daugthers)));
                    // daughters shares
                    daughters_shares = (num_of_daugthers > 0 ? num_of_daugthers * (x_share / (2 * num_of_sons + num_of_daugthers)) : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers >= 2)
                {
                    daughters_shares = 2 * (total_PRS / 3);
                    rem_aft_dau_share = total_PRS - daughters_shares;
                    husband_share = (husband == 1 ? afourth * rem_aft_dau_share : 0);
                    mother_share = (mother == 1 ? asixth * rem_aft_dau_share : 0);
                    father_share = (father == 1 ? asixth * rem_aft_dau_share : 0);
                    brother_share = (num_of_bro == 1 ? afourth * rem_aft_dau_share : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 1)
                {
                    daughters_shares = total_PRS / 2;
                    husband_share = (husband == 1 ? afourth * total_PRS : 0);
                    rem_aft_dau_share = total_PRS - daughters_shares;
                    mother_share = (mother == 1 ? asixth * rem_aft_dau_share : 0);
                    father_share = (father == 1 ? asixth * rem_aft_dau_share : 0);
                    brother_share = (num_of_bro == 1 ? afourth * rem_aft_dau_share : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && num_of_bro == 0 && num_of_sis == 0)
                {
                    mother_share = (mother == 1 ? one_third * total_PRS : 0);
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    father_share = total_PRS - (mother_share + husband_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && (num_of_bro + num_of_sis) >= 2)
                {
                    mother_share = asixth * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);

                    one_third_PRS = one_third * total_PRS;
                    brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                    mother_share += total_PRS - (mother_share + husband_share + brother_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 1 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = asixth * total_PRS;
                    mother_share += total_PRS - (mother_share + husband_share + brother_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 0 && num_of_sis == 1)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? (1 / 2) * total_PRS : 0);
                    sister_share = asixth * total_PRS;
                    mother_share += total_PRS - (mother_share + husband_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis == 1)
                {
                    husband_share = (husband_share == 1 ? half * total_PRS : 0);
                    sister_share = half * total_PRS;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro >= 1 && num_of_sis == 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = total_PRS - husband_share;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis >= 2)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    rem_aft_hus = total_PRS - husband_share;

                    sister_share = two_thirds * rem_aft_hus;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro > 0 && num_of_sis > 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    rem_aft_hus = total_PRS - husband_share;

                    brother_share = num_of_bro * (2 * (rem_aft_hus / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (rem_aft_hus / (2 * num_of_bro + num_of_sis));
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 0 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    mother_share += total_PRS - (mother_share + husband_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis == 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && (num_of_bro + num_of_sis) >= 2)
                {
                    mother_share = asixth * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    one_third_PRS = one_third * total_PRS;
                    brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                    father_share = total_PRS - (mother_share + husband_share + brother_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 1 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = asixth * total_PRS;
                    father_share = total_PRS - (mother_share + husband_share + brother_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && (num_of_bro + num_of_sis) >= 2)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    one_third_PRS = one_third * total_PRS;
                    brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                    father_share = total_PRS - (mother_share + husband_share + brother_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 0 && num_of_sis == 1)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    sister_share = asixth * total_PRS;
                    father_share = total_PRS - (mother_share + husband_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis == 1)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    sister_share = half * total_PRS;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro >= 1 && num_of_sis == 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = total_PRS - husband_share;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 1 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? (1 / 2) * total_PRS : 0);
                    brother_share = asixth * total_PRS;
                    father_share += total_PRS - (mother_share + husband_share + brother_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 0 && num_of_sis == 1)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    sister_share = asixth * total_PRS;
                    father_share += total_PRS - (mother_share + husband_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && num_of_bro == 1 && num_of_sis == 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = asixth * total_PRS;
                    father_share += total_PRS - (husband_share + brother_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && num_of_bro == 0 && num_of_sis == 1)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    sister_share = asixth * total_PRS;
                    father_share += total_PRS - (husband_share + sister_share);
                }

                rem_share = total_PRS - (sons_shares + daughters_shares + mother_share + father_share + husband_share + brother_share + sister_share);

                //Console.WriteLine(" The rem share = " + rem_share + " sons will have " + sons_shares);

               

         }

        

        }
        public string getSons()
        {
            return Convert.ToString (  sons_shares ); 
            
        }

        


        // TODO: setter and geter for all this values 
        //TODO : Constructor in case the the wifs will inharite


        /* public void run_programe_2()
         {
             if (num_of_sons > 0)
             {
                 // wives shares
                 wives_share = (num_of_wives > 0 ? (1 / 8) * total_PRS : 0);
                 mother_share = (mother == 1 ? (1 / 6) * total_PRS : 0);
                 father_share = (father == 1 ? (1 / 6) * total_PRS : 0);
                 rem_aft_wif = total_PRS - wives_share - mother_share - father_share;
                 // sons shares
                 sons_shares = num_of_sons * (2 * (rem_aft_wif / (2 * num_of_sons + num_of_daugthers)));
                 // daughters shares
                 daughters_shares = (num_of_daugthers > 0 ? num_of_daugthers * (rem_aft_wif / (2 * num_of_sons + num_of_daugthers)) : 0);
             }
             else if (num_of_sons == 0 && num_of_daugthers >= 2)
             {
                 // wives shares
                 daughters_shares = 2 * (total_PRS / 3);

                 rem_aft_dau_share = total_PRS - daughters_shares;
                 mother_share = (mother == 1 ? (1 / 6) * rem_aft_dau_share : 0);
                 father_share = (father == 1 ? (1 / 6) * rem_aft_dau_share : 0);
                 wives_share = (num_of_wives > 0 ? (1 / 8) * rem_aft_dau_share : 0);
             }
             else if (num_of_sons == 0 && num_of_daugthers == 1)
             {
                 daughters_shares = total_PRS / 2;

                 rem_aft_dau_share = total_PRS - daughters_shares;
                 mother_share = (mother == 1 ? (1 / 6) * rem_aft_dau_share : 0);
                 father_share = (father == 1 ? (1 / 6) * rem_aft_dau_share : 0);
                 wives_share = (num_of_wives > 0 ? (1 / 8) * rem_aft_dau_share : 0);
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && num_of_bro == 0 && num_of_sis == 0)
             {
                 mother_share = (mother == 1 ? (1 / 3) * total_PRS : 0);
                 half_PRS = total_PRS / 2;
                 rem_aft_wif = total_PRS - mother_share;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * rem_aft_wif : 0);
                 father_share = total_PRS - (mother_share + wives_share);
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && (num_of_bro + num_of_sis) >= 2)
             {
                 mother_share = (1 / 6) * total_PRS;
                 one_third_PRS = (1 / 3) * total_PRS;

                 brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                 sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                 half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * half_PRS : 0);
                 mother_share += total_PRS - (mother_share + brother_share + sister_share + (wives_share * num_of_wives));
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 1 && num_of_sis == 0)
             {
                 mother_share = (1 / 3) * total_PRS;
                 brother_share = (1 / 6) * total_PRS;
                 half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * half_PRS : 0);
                 mother_share += total_PRS - (mother_share + brother_share + (wives_share * num_of_wives));
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 0 && num_of_sis == 1)
             {
                 mother_share = (1 / 3) * total_PRS;
                 sister_share = (1 / 6) * total_PRS;
                 half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * total_PRS : 0);
                 mother_share += total_PRS - (mother_share + sister_share + (wives_share * num_of_wives));
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis == 1)
             {
                 sister_share = (1 / 2) * total_PRS;
                 half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * half_PRS : 0);
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro >= 1 && num_of_sis == 0)
             {
                 half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * half_PRS : 0);
                 brother_share = total_PRS - (wives_share * num_of_wives);
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis >= 2)
             {
                 half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * half_PRS : 0);
                 rem_aft_wif = total_PRS - (wives_share * num_of_wives);
                 sister_share = (2 / 3) * rem_aft_wif;
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro > 0 && num_of_sis > 0)
             {
                 half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * half_PRS : 0);
                 rem_aft_wif = total_PRS - (wives_share * num_of_wives);

                 brother_share = num_of_bro * (2 * (rem_aft_wif / (2 * num_of_bro + num_of_sis)));
                 sister_share = num_of_sis * (rem_aft_wif / (2 * num_of_bro + num_of_sis));
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 0 && num_of_sis == 0)
             {
                 mother_share = (1 / 3) * total_PRS;
                 half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * half_PRS : 0);
                 mother_share += total_PRS - (mother_share + (wives_share * num_of_wives));
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis == 0)
             {
                 // half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * total_PRS : 0);
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && (num_of_bro + num_of_sis) >= 2)
             {
                 mother_share = (1 / 6) * total_PRS;
                 one_third_PRS = (1 / 3) * total_PRS;
                 brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                 sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                 // half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * total_PRS : 0);
                 father_share = total_PRS - (mother_share + brother_share + sister_share + (wives_share * num_of_wives));
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 1 && num_of_sis == 0)
             {
                 mother_share = (1 / 3) * total_PRS;
                 brother_share = (1 / 6) * total_PRS;
                 half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * half_PRS : 0);
                 father_share = total_PRS - (mother_share + brother_share + (wives_share * num_of_wives));
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 0 && num_of_sis == 1)
             {
                 mother_share = (1 / 3) * total_PRS;
                 sister_share = (1 / 6) * total_PRS;
                 half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * half_PRS : 0);
                 father_share = total_PRS - (mother_share + sister_share + (wives_share * num_of_wives));
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && (num_of_bro + num_of_sis) >= 2)
             {
                 one_third_PRS = (1 / 3) * total_PRS;
                 brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                 sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                 half_PRS = total_PRS / 2;
                 // wives_share = (num_of_wives > 0 ? (1 / 4) * total_PRS : 0);
                 father_share = total_PRS - (brother_share + sister_share + (wives_share * num_of_wives));
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && num_of_bro == 1 && num_of_sis == 0)
             {
                 brother_share = (1 / 6) * total_PRS;
                 half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * half_PRS : 0);
                 father_share = total_PRS - (mother_share + brother_share + (wives_share * num_of_wives));
             }
             else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && num_of_bro == 0 && num_of_sis == 1)
             {
                 sister_share = (1 / 6) * total_PRS;
                 half_PRS = total_PRS / 2;
                 wives_share = (num_of_wives > 0 ? (1 / 4) * half_PRS : 0);
                 father_share += total_PRS - (sister_share + (wives_share * num_of_wives));
             }

             rem_share = total_PRS - (sons_shares + daughters_shares + mother_share + father_share + wives_share + brother_share + sister_share);

         } */





