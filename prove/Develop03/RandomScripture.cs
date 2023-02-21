using System;

public class RandomScripture
{
    List<string> SingleScriptures = new List<string>
    {
        "Alma 18:27 [And he said, Yea.",
        "1 Nephi 2:15 [And my father dwelt in a tent.",
        "Alma 18:19 [Ammon answered and said unto him: I am not.",
        "1 Nephi 6:2 [For it sufficeth me to say that we are descendants of Joseph.",
        "2 Nephi 2:25 [Adam fell that men might be; and men are, that they might have joy.",
        "Jacob 1:12 [And it came to pass that Nephi died."
    };
    List<string> MultipleScriptures = new List<string>
    {
        "2 Nephi 9:28-29 [O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish.  But to be learned is good if they hearken unto the counsels of God.",
        "Jacob 2:18-19 [But before ye seek for riches, seek ye for the kingdom of God. And after ye have obtained a hope in Christ ye shall obtain riches, if ye seek them; and ye will seek them for the intent to do good—to clothe the naked, and to feed the hungry, and to liberate the captive, and administer relief to the sick and the afflicted.",
        "James 1:5-6 If [any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him aask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed."
    };

    public string GetShortScripture()
    {
        Random random = new Random();
        int ScriptureIndex = random.Next(SingleScriptures.Count);
        string text = SingleScriptures[ScriptureIndex];
        return text;
    }
    public string GetlongScriptures()
    {
        Random random = new Random();
        int ScriptureIndex = random.Next(MultipleScriptures.Count);
        string text = MultipleScriptures[ScriptureIndex];
        return text;
    }
}