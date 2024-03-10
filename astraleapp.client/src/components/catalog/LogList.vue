<script setup lang="ts">
import axios from "axios"

import type ShipsBoats from "../ships/ShipsBoats.vue"

const respVal = await axios.get<Array<typeof ShipsBoats>>("/api/ships")
const responseData = respVal.data
// to-do:
// defineProps<>() // code ...
</script>

<template>
  <section :class="styles.CardSection">
    <h1>{{ responseData.keys }}</h1>
    <h2>{{ responseData.length }}</h2>
  </section>
  <article :class="styles.CardArticle">
    <div :class="styles.CardDescriptor">{{ responseData.entries }}</div>
    <span :class="styles.CardFlavor">{{ responseData.values }}</span>
  </article>
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
