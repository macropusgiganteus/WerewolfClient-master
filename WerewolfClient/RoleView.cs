using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerewolfClient
{
    public partial class RoleView : Form
    {
        private bool THlanguage = false;
        private Form _mainform;
        public RoleView()
        {
            InitializeComponent();
        }

        public void GetRole(Form mainform)
        {
            _mainform = mainform;
        }

        private void Btn2P_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void RoleIcon_Click(object sender, EventArgs e)
        {

            try
            {
                PictureBox btn = (PictureBox)sender;
                string role = btn.Name;
                RolePic.Image = btn.Image;
                Rolename.Text = btn.Name;

                if (!THlanguage)
                {
                    switch (role)
                    {
                        case "Alpha_Werewolf":
                            Teamside.Text = "Werewolves";
                            GoalDes.Text = "Eliminate all village members and the Serial Killer, Arsonist or Sect Leader";
                            AbilityDes.Text = "Kill one player every night and If there's a draw in the night voting phase, target with alpha's vote wins";
                            break;
                        case "Werewolf":
                            Teamside.Text = "Werewolves";
                            GoalDes.Text = "Eliminate all village members and the Serial Killer, Arsonist or Sect Leader";
                            AbilityDes.Text = "Kill one player every night";
                            break;
                        case "Aura_Seer":
                            Teamside.Text = "Villagers";
                            GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                            AbilityDes.Text = "At night can see the aura of any player he selects.";
                            break;
                        case "Bodyguard":
                            Teamside.Text = "Villagers";
                            GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                            AbilityDes.Text = "Can protect a player he picks every night. If the werewolves/serial killer try to kill that player, the bodyguard gets attacked instead. He survives the first attack but dies on the second.";
                            break;
                        case "Doctor":
                            Teamside.Text = "Villagers";
                            GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                            AbilityDes.Text = "At night he can protect any player from dying.";
                            break;
                        case "Fool":
                            Teamside.Text = "Special";
                            GoalDes.Text = "Get lynched by the village";
                            AbilityDes.Text = "No special abilities.";
                            break;
                        case "Gunner":
                            Teamside.Text = "Villagers";
                            GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                            AbilityDes.Text = "Can kill 2 players every game, one per round. After the first shot, the role gets revealed to all players.";
                            break;
                        case "Head_Hunter":
                            Teamside.Text = "Villagers/Special";
                            GoalDes.Text = "Get their target lynched - If the target dies in a different way, becomes member of village team";
                            AbilityDes.Text = "No special abilities.";
                            break;
                        case "Jailer":
                            Teamside.Text = "Villagers";
                            GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                            AbilityDes.Text = "Can put a player in jail every day. The night after, that player won't be able to use their role's ability overnight. Once every game, he can kill the prisoner.";
                            break;
                        case "Medium":
                            Teamside.Text = "Villagers";
                            GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                            AbilityDes.Text = "Can talk with the dead players at night. Can also revive one of them once every game.";
                            break;
                        case "Priest":
                            Teamside.Text = "Villagers";
                            GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                            AbilityDes.Text = "Can throw holy water once every game at a player he selects. If that player is a werewolf, they die. If not, the priest dies instead.";
                            break;
                        case "Seer":
                            Teamside.Text = "Villagers";
                            GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                            AbilityDes.Text = "At night can see the role of any player he selects.";
                            break;
                        case "Serial_Killer":
                            Teamside.Text = "Special";
                            GoalDes.Text = "Be the last player alive";
                            AbilityDes.Text = "Can kill one player every night. Can't be killed by the werewolves.";
                            break;
                        case "Villager":
                            Teamside.Text = "Villagers";
                            GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                            AbilityDes.Text = "No special abilities.";
                            break;
                        case "Wolf_Seer":
                            Teamside.Text = "Werewolves";
                            GoalDes.Text = "Eliminate all village members and the Serial Killer";
                            AbilityDes.Text = "At night can see the role of any player he selects. ";
                            break;
                        case "Wolf_Shaman":
                            Teamside.Text = "Werewolves";
                            GoalDes.Text = "Eliminate all village members and the Serial Killer";
                            AbilityDes.Text = "Werewolf + can enchant a player every day, that makes the player look like a werewolf to seers and aura seers";
                            break;
                        default:

                            break;
                    }
                }
                else
                {

                    switch (role)
                    {
                        case "Alpha_Werewolf":
                            Teamside.Text = "หมาป่า";
                            GoalDes.Text = "ฆ่าฝั่ง Villagers ทุกคน และ Serial_Killer";
                            AbilityDes.Text = "คุณคือผู้นำเหล่าหมาป่าเมื่อผลโหวตฆ่าในตอนกลางคืนมีคะแนนเท่ากัน คะแนนโหวตของคุณคือ 2 แต้ม";
                            break;
                        case "Werewolf":
                            Teamside.Text = "หมาป่า";
                            GoalDes.Text = "ฆ่าฝั่ง Villagers ทุกคน และ Serial_Killer";
                            AbilityDes.Text = "คุณสามารถเลือกฆ่าเหยื่อในตอนกลางคืนตามผลโหวตในกลุ่มหมาป่า คุณมี 1แต้มในการเลือกโหวตในคืนนั้นๆ";
                            break;
                        case "Aura_Seer":
                            Teamside.Text = "ชาวบ้าน";
                            GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serial_Killer";
                            AbilityDes.Text = "ในแต่ละคืน Aura Seer จะสามารถส่องผู้เล่นคนอื่นได้แต่จะไม่ชัดเท่า Seer เพราะ Aura Seer จะทราบแค่ ฝ่ายดี ฝ่ายร้าย และไม่ทราบฝ่าย แค่นั้น";
                            break;
                        case "Bodyguard":
                            Teamside.Text = "ชาวบ้าน";
                            GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serial_Killer";
                            AbilityDes.Text = "การ์ดจะสามารถปกป้องผู้เล่น 1 คนได้ในคืนนั้นๆ ผู้เล่นคนนั้นจะไม่ถูกฆ่า แต่คุณจะโดนโจมตีแทน คุณจะไม่เป็นไรในคืนแรกเพราะคุณแข็งแกร่งมาก แต่ถ้าคุณโดนโจมตีอีกครั้งคุณจะตาย ที่สำคัญบอดี้การ์ดจะปกป้องตัวเองอัตโนมัติ";
                            break;
                        case "Doctor":
                            Teamside.Text = "ชาวบ้าน";
                            GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serial_Killer";
                            AbilityDes.Text = "เลือกปกป้องผู้เล่น 1 คนในตอนกลางคืนเพื่อไม่ให้เขาตาย";
                            break;
                        case "Fool":
                            Teamside.Text = "พิเศษ";
                            GoalDes.Text = "ทำยังไงก็ได้ให้คนเขาโหวตคุณ ถ้าเขาโหวตประหารคุณ คุณจะชนะทันที";
                            AbilityDes.Text = "ไม่มี";
                            break;
                        case "Gunner":
                            Teamside.Text = "ชาวบ้าน";
                            GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serialkiller";
                            AbilityDes.Text = "เป็นดาบสองคมเลยครับคาแรคเตอร์นี้ โดยคุณมีกระสุนเพียง 2 นัด เมื่อคุณยิงไปแล้วนัดแรก คุณจะถูกเปิดเผยตัวตนทันทีว่าคุณคือ มือปืน ถ้ายิงคนผิดก็ซวยไป  !!";
                            break;
                        case "Head_Hunter":
                            Teamside.Text = "ชาวบ้าน/พิเศษ";
                            GoalDes.Text = "คุณต้องทำให้เป้าหมายโดนแขวนคอประหารจากชาวบ้าน ถ้าเป้าหมายของคุณตายด้วยวิธีอื่น คุณจะกลายเป็นชาวบ้านธรรมดา";
                            AbilityDes.Text = "ไม่มี";
                            break;
                        case "Jailer":
                            Teamside.Text = "ชาวบ้าน";
                            GoalDes.Text = "ฆ่าฝั่ง Werewolf ทุกตัว และ Serial_Killer";
                            AbilityDes.Text = "ในตอนกลางวันคุณสามารถเลือกผู้เล่น 1 คนเพื่อคุมขัง เมื่อถึงตอนกลางคืน คุณสามารถพูดคุยกับคนที่คุณคุมขังเป็นการส่วนตัว และนักโทษจะไม่สามารถใช้สกิลในคืนนั้นๆได้ ถ้านักโทษที่คุณสงสัยว่าเป้นฝ่ายร้าย คุณสามารถฆ่าเขาได้เลย ขังแล้วเชือดทิ้งสะ";
                            break;
                        case "Medium":
                            Teamside.Text = "ชาวบ้าน";
                            GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serial_Killer";
                            AbilityDes.Text = "ในตอนกลางคืนคุณสามารถคุยกับคนที่ตายไปแล้วได้แบบไม่เปิดเผยตัวตน และคุณสามารถชุบชีวิตได้ 1 ครั้งเท่านั้น";
                            break;
                        case "Priest":
                            Teamside.Text = "ชาวบ้าน";
                            GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serial_Killer";
                            AbilityDes.Text = "พระคนนี้มีน้ำมนต์ และน้ำมนต์นี่ล่ะสาดหมาป่าตาย แต่ถ้าคุณสาดมั่วใส่คนที่ไม่ใช่หมาป่าคุณจะตายเอง";
                            break;
                        case "Seer":
                            Teamside.Text = "ชาวบ้าน";
                            GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serial_Killer";
                            AbilityDes.Text = "ในแต่ละคืน คุณสามารถส่องคนอื่นได้ว่าเขาเป็นใคร";
                            break;
                        case "Serial_Killer":
                            Teamside.Text = "พิเศษ";
                            GoalDes.Text = "ถ้าคุณรอดเป็นคนสุดท้าย คุณจะชนะ ";
                            AbilityDes.Text = "ในแต่ละคืน คุณมีมีดสามารถเลือกฆ่าได้คืนละ 1 คน และที่สำคัญในตอนกลางคืนคุณจะไม่โดนหมาป่าฆ่าอีกด้วย";
                            break;
                        case "Villager":
                            Teamside.Text = "ชาวบ้าน";
                            GoalDes.Text = "ฆ่าฝั่ง Werewolf ทุกตัว และ Serial_Killer";
                            AbilityDes.Text = "";
                            break;
                        case "Wolf_Seer":
                            Teamside.Text = "หมาป่า";
                            GoalDes.Text = "ฆ่าฝั่ง Villagers ทุกคน และ Serial_Killer";
                            AbilityDes.Text = "ในตอนกลางคืน คุณสามารถดูบทบาทของคนที่คุณเลือกได้ 1 คน ว่าเขาเป็นใครแล้วแจ้งเพื่อนหมาคุณเลือกฆ่าได้เลย แต่ถ้าคุณเหลือเป็นหมาป่าคนสุดท้ายคุณจะเป็นแค่หมาธรรมดาคนนึงเลือกฆ่าได้ตามปกติ";
                            break;
                        case "Wolf_Shaman":
                            Teamside.Text = "หมาป่า";
                            GoalDes.Text = "ฆ่าฝั่ง Villagers ทุกคน และ Serial_Killer";
                            AbilityDes.Text = "ในตอนกลางวันสามารถร่ายเวทย์ใส่คนอื่นได้ ทำให้คนที่คุณร่ายใส่ถูกมองเห็นเป็นมนุษย์หมาป่า เมื่อพวกที่สามารถส่องได้อย่าง Seer และ Aura Seer ส่องคนที่คุณร่ายเวทย์ใส่ก็จะพบว่าคนนั้นเป็นฝ่ายหมาป่า ถ้าคุณคือหมาป่าตัวสุดท้ายจะไม่สามารถร่ายเวทย์ได้ แต่สามารถฆ่าคนได้ในตอนกลางคืนแบบหมาป่าปกติ";
                            break;
                        default:

                            break;
                    }
                }
            }
            catch
            {

            }



        }

        private void Language_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string role = Rolename.Text;
            if (btn.Text == "TH")
            {
                THlanguage = true;
                btn.Text = "ENG";
            }
            else
            {
                THlanguage = false;
                btn.Text = "TH";
            }
            if (!THlanguage)
            {
                Goal.Text = "Goal";
                Ability.Text = "Ability";
                Team.Text = "Team";
                
                switch (role)
                {
                    case "Alpha_Werewolf":
                        Teamside.Text = "Werewolves";
                        GoalDes.Text = "Eliminate all village members and the Serial Killer, Arsonist or Sect Leader";
                        AbilityDes.Text = "Kill one player every night and If there's a draw in the night voting phase, target with alpha's vote wins";
                        break;
                    case "Werewolf":
                        Teamside.Text = "Werewolves";
                        GoalDes.Text = "Eliminate all village members and the Serial Killer, Arsonist or Sect Leader";
                        AbilityDes.Text = "Kill one player every night";
                        break;
                    case "Aura_Seer":
                        Teamside.Text = "Villagers";
                        GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                        AbilityDes.Text = "At night can see the aura of any player he selects.";
                        break;
                    case "Bodyguard":
                        Teamside.Text = "Villagers";
                        GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                        AbilityDes.Text = "Can protect a player he picks every night. If the werewolves/serial killer try to kill that player, the bodyguard gets attacked instead. He survives the first attack but dies on the second.";
                        break;
                    case "Doctor":
                        Teamside.Text = "Villagers";
                        GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                        AbilityDes.Text = "At night he can protect any player from dying.";
                        break;
                    case "Fool":
                        Teamside.Text = "Special";
                        GoalDes.Text = "Get lynched by the village";
                        AbilityDes.Text = "No special abilities.";
                        break;
                    case "Gunner":
                        Teamside.Text = "Villagers";
                        GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                        AbilityDes.Text = "Can kill 2 players every game, one per round. After the first shot, the role gets revealed to all players.";
                        break;
                    case "Head_Hunter":
                        Teamside.Text = "Villagers/Special";
                        GoalDes.Text = "Get their target lynched - If the target dies in a different way, becomes member of village team";
                        AbilityDes.Text = "No special abilities.";
                        break;
                    case "Jailer":
                        Teamside.Text = "Villagers";
                        GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                        AbilityDes.Text = "Can put a player in jail every day. The night after, that player won't be able to use their role's ability overnight. Once every game, he can kill the prisoner.";
                        break;
                    case "Medium":
                        Teamside.Text = "Villagers";
                        GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                        AbilityDes.Text = "Can talk with the dead players at night. Can also revive one of them once every game.";
                        break;
                    case "Priest":
                        Teamside.Text = "Villagers";
                        GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                        AbilityDes.Text = "Can throw holy water once every game at a player he selects. If that player is a werewolf, they die. If not, the priest dies instead.";
                        break;
                    case "Seer":
                        Teamside.Text = "Villagers";
                        GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                        AbilityDes.Text = "At night can see the role of any player he selects.";
                        break;
                    case "Serial_Killer":
                        Teamside.Text = "Special";
                        GoalDes.Text = "Be the last player alive";
                        AbilityDes.Text = "Can kill one player every night. Can't be killed by the werewolves.";
                        break;
                    case "Villager":
                        Teamside.Text = "Villagers";
                        GoalDes.Text = "Eliminate all the Werewolves and the Serial Killer";
                        AbilityDes.Text = "No special abilities.";
                        break;
                    case "Wolf_Seer":
                        Teamside.Text = "Werewolves";
                        GoalDes.Text = "Eliminate all village members and the Serial Killer";
                        AbilityDes.Text = "At night can see the role of any player he selects. ";
                        break;
                    case "Wolf_Shaman":
                        Teamside.Text = "Werewolves";
                        GoalDes.Text = "Eliminate all village members and the Serial Killer";
                        AbilityDes.Text = "Werewolf + can enchant a player every day, that makes the player look like a werewolf to seers and aura seers";
                        break;
                    default:

                        break;
                }
            }
            else
            {
                Goal.Text = "เป้าหมาย";
                Ability.Text = "ความสามารถพิเศษ";
                Team.Text = "ฝั่ง";   
                switch (role)
                {
                    case "Alpha_Werewolf":
                        Teamside.Text = "หมาป่า";
                        GoalDes.Text = "ฆ่าฝั่ง Villagers ทุกคน และ Serial_Killer";
                        AbilityDes.Text = "คุณคือผู้นำเหล่าหมาป่าเมื่อผลโหวตฆ่าในตอนกลางคืนมีคะแนนเท่ากัน คะแนนโหวตของคุณคือ 2 แต้ม";
                        break;
                    case "Werewolf":
                        Teamside.Text = "หมาป่า";
                        GoalDes.Text = "ฆ่าฝั่ง Villagers ทุกคน และ Serial_Killer";
                        AbilityDes.Text = "คุณสามารถเลือกฆ่าเหยื่อในตอนกลางคืนตามผลโหวตในกลุ่มหมาป่า คุณมี 1แต้มในการเลือกโหวตในคืนนั้นๆ";
                        break;
                    case "Aura_Seer":
                        Teamside.Text = "ชาวบ้าน";
                        GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serial_Killer";
                        AbilityDes.Text = "ในแต่ละคืน Aura Seer จะสามารถส่องผู้เล่นคนอื่นได้แต่จะไม่ชัดเท่า Seer เพราะ Aura Seer จะทราบแค่ ฝ่ายดี ฝ่ายร้าย และไม่ทราบฝ่าย แค่นั้น";
                        break;
                    case "Bodyguard":
                        Teamside.Text = "ชาวบ้าน";
                        GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serial_Killer";
                        AbilityDes.Text = "การ์ดจะสามารถปกป้องผู้เล่น 1 คนได้ในคืนนั้นๆ ผู้เล่นคนนั้นจะไม่ถูกฆ่า แต่คุณจะโดนโจมตีแทน คุณจะไม่เป็นไรในคืนแรกเพราะคุณแข็งแกร่งมาก แต่ถ้าคุณโดนโจมตีอีกครั้งคุณจะตาย ที่สำคัญบอดี้การ์ดจะปกป้องตัวเองอัตโนมัติ";
                        break;
                    case "Doctor":
                        Teamside.Text = "ชาวบ้าน";
                        GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serial_Killer";
                        AbilityDes.Text = "เลือกปกป้องผู้เล่น 1 คนในตอนกลางคืนเพื่อไม่ให้เขาตาย";
                        break;
                    case "Fool":
                        Teamside.Text = "พิเศษ";
                        GoalDes.Text = "ทำยังไงก็ได้ให้คนเขาโหวตคุณ ถ้าเขาโหวตประหารคุณ คุณจะชนะทันที";
                        AbilityDes.Text = "ไม่มี";
                        break;
                    case "Gunner":
                        Teamside.Text = "ชาวบ้าน";
                        GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serialkiller";
                        AbilityDes.Text = "เป็นดาบสองคมเลยครับคาแรคเตอร์นี้ โดยคุณมีกระสุนเพียง 2 นัด เมื่อคุณยิงไปแล้วนัดแรก คุณจะถูกเปิดเผยตัวตนทันทีว่าคุณคือ มือปืน ถ้ายิงคนผิดก็ซวยไป  !!";
                        break;
                    case "Head_Hunter":
                        Teamside.Text = "ชาวบ้าน/พิเศษ";
                        GoalDes.Text = "คุณต้องทำให้เป้าหมายโดนแขวนคอประหารจากชาวบ้าน ถ้าเป้าหมายของคุณตายด้วยวิธีอื่น คุณจะกลายเป็นชาวบ้านธรรมดา";
                        AbilityDes.Text = "ไม่มี";
                        break;
                    case "Jailer":
                        Teamside.Text = "ชาวบ้าน";
                        GoalDes.Text = "ฆ่าฝั่ง Werewolf ทุกตัว และ Serial_Killer";
                        AbilityDes.Text = "ในตอนกลางวันคุณสามารถเลือกผู้เล่น 1 คนเพื่อคุมขัง เมื่อถึงตอนกลางคืน คุณสามารถพูดคุยกับคนที่คุณคุมขังเป็นการส่วนตัว และนักโทษจะไม่สามารถใช้สกิลในคืนนั้นๆได้ ถ้านักโทษที่คุณสงสัยว่าเป้นฝ่ายร้าย คุณสามารถฆ่าเขาได้เลย ขังแล้วเชือดทิ้งสะ";
                        break;
                    case "Medium":
                        Teamside.Text = "ชาวบ้าน";
                        GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serial_Killer";
                        AbilityDes.Text = "ในตอนกลางคืนคุณสามารถคุยกับคนที่ตายไปแล้วได้แบบไม่เปิดเผยตัวตน และคุณสามารถชุบชีวิตได้ 1 ครั้งเท่านั้น";
                        break;
                    case "Priest":
                        Teamside.Text = "ชาวบ้าน";
                        GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serial_Killer";
                        AbilityDes.Text = "พระคนนี้มีน้ำมนต์ และน้ำมนต์นี่ล่ะสาดหมาป่าตาย แต่ถ้าคุณสาดมั่วใส่คนที่ไม่ใช่หมาป่าคุณจะตายเอง";
                        break;
                    case "Seer":
                        Teamside.Text = "ชาวบ้าน";
                        GoalDes.Text = "ฆ่าฝั่ง Werewolves ทุกตัว และ Serial_Killer";
                        AbilityDes.Text = "ในแต่ละคืน คุณสามารถส่องคนอื่นได้ว่าเขาเป็นใคร";
                        break;
                    case "Serial_Killer":
                        Teamside.Text = "พิเศษ";
                        GoalDes.Text = "ถ้าคุณรอดเป็นคนสุดท้าย คุณจะชนะ ";
                        AbilityDes.Text = "ในแต่ละคืน คุณมีมีดสามารถเลือกฆ่าได้คืนละ 1 คน และที่สำคัญในตอนกลางคืนคุณจะไม่โดนหมาป่าฆ่าอีกด้วย";
                        break;
                    case "Villager":
                        Teamside.Text = "ชาวบ้าน";
                        GoalDes.Text = "ฆ่าฝั่ง Werewolf ทุกตัว และ Serial_Killer";
                        AbilityDes.Text = "";
                        break;
                    case "Wolf_Seer":
                        Teamside.Text = "หมาป่า";
                        GoalDes.Text = "ฆ่าฝั่ง Villagers ทุกคน และ Serial_Killer";
                        AbilityDes.Text = "ในตอนกลางคืน คุณสามารถดูบทบาทของคนที่คุณเลือกได้ 1 คน ว่าเขาเป็นใครแล้วแจ้งเพื่อนหมาคุณเลือกฆ่าได้เลย แต่ถ้าคุณเหลือเป็นหมาป่าคนสุดท้ายคุณจะเป็นแค่หมาธรรมดาคนนึงเลือกฆ่าได้ตามปกติ";
                        break;
                    case "Wolf_Shaman":
                        Teamside.Text = "หมาป่า";
                        GoalDes.Text = "ฆ่าฝั่ง Villagers ทุกคน และ Serial_Killer";
                        AbilityDes.Text = "ในตอนกลางวันสามารถร่ายเวทย์ใส่คนอื่นได้ ทำให้คนที่คุณร่ายใส่ถูกมองเห็นเป็นมนุษย์หมาป่า เมื่อพวกที่สามารถส่องได้อย่าง Seer และ Aura Seer ส่องคนที่คุณร่ายเวทย์ใส่ก็จะพบว่าคนนั้นเป็นฝ่ายหมาป่า ถ้าคุณคือหมาป่าตัวสุดท้ายจะไม่สามารถร่ายเวทย์ได้ แต่สามารถฆ่าคนได้ในตอนกลางคืนแบบหมาป่าปกติ";
                        break;
                    default:

                        break;
                }
            }
        }
    }
}

    

