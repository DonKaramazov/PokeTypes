# PokeTypes
Select a pokemon and it displays the strengths and weaknesses of each type. 
Is only valid from the sixth generation.


# Technical
Coded in c# 7 with VS Community 17 .Net Framework 4.5.2

Inspired by the <i> builder pattern </i>  which creates easily the types :
<pre><code class='language-cs'>
PokemonType fairy = new PokeBuilder(Element.FAIRY)
                .VulnerableTo(Element.STEEL, Element.POISON)
                .ResistantTo(Element.FIGHTING, Element.BUG, Element.DARK)
                .ImmuneTo(Element.DRAGON)
                .Build();
</code></pre>

# Preview

<img id="img_preview" src="https://img15.hostingpics.net/pics/311436Capture.png" alt="Capture" title="Capture">




