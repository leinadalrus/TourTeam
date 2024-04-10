<script setup lang="ts">
// to-do:
// defineComponent<>() --- code ...
</script>

<template>
  <section :class="styles.CardSection">
    <article :class="styles.CardArticle">
      <slot :class="styles.CardDescriptor"></slot>
    </article>
  </section>
</template>

<style scoped module="styles" lang="scss">
$card-background: #191c21;
$card-width: 16em;
$card-height: calc(var($card-width) / 2.1);

.CardSection {
  background: $card-background;
  width: $card-width;
  height: $card-height;
  padding: 0.5em;
  position: relative;
  border-radius: 0.5em;
}

.CardArticle {
  justify-content: center;
  align-items: center;
  text-align: center;
  display: flex;
  font-size: calc(2em / 0.13em);
  color: #e9f2f9;
  cursor: pointer;
}

.CardDescriptor {
  color: #ebf7f8;
  font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
  font-weight: lighter;
  font-size: smaller;
  text-decoration: none;
}

.CardFlavor {
  color: #ebf7f8;
  font-family: 'Times New Roman', Times, serif;
  font-weight: lighter;
  font-size: smaller;
  text-decoration: none;
}
</style>
