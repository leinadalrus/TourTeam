<script setup lang="ts">
import { ref, watch } from "vue"

enum StarScores {
  OneStar = 1,
  TwoStars = 2,
  ThreeStars = 3,
  FourStars = 4,
  FiveStars = 5
}

interface CardPlatform {
  title: string
  description: string
  flavour: string
  image: string
}

const tradingCard = ref<CardPlatform>({
  title: "/title",
  description: "/description",
  flavour: "/flavour",
  image: "/assets"
})

const starScore = ref<StarScores>()

watch([tradingCard, starScore], () => { })
</script>

<template>
  <div>{{ tradingCard.title }}</div>
  <span>{{ starScore }}</span>
  <section>
    <img :src="tradingCard.image" :alt="tradingCard.flavour" />
    <article>
      <p>{{ tradingCard.description }}</p>
      <i>{{ tradingCard.flavour }}</i>
    </article>
  </section>
</template>

<style scoped lang="scss"></style>