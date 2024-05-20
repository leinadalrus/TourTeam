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
  <div class="card-banner">{{ tradingCard.title }}</div>
  <span>{{ starScore }}</span>
  <section class="card-container">
    <img :src="tradingCard.image" :alt="tradingCard.flavour" />
    <article class="card-content">
      <p>{{ tradingCard.description }}</p>
      <i>{{ tradingCard.flavour }}</i>
    </article>
  </section>
</template>

<style scoped lang="scss">
  .card-banner {
    text-orientation: sideways;
    writing-mode: vertical-rl;
    word-break: break-word;
    max-height: 32vh;
  }

  .card-background {
  }

  .card-container {
    display: flex;
    overflow: scroll;
    flex: 1;
    background-color: #0f1014;
    align-items: center;
    justify-content: center;
    scrollbar-width: none;
    -ms-overflow-style: none;
  }

  .card-content {
    clip-path: polygon(0 0%, 100% 0, 100% calc(100% - 0rem), calc(100% - 0rem) 100%, 0 100%, 0% calc(100% - 0rem));
    max-width: 15vw;
    max-height: 32vh;
    padding: 0.25rem 1rem;
    margin: auto;
    opacity: 99%;
    backdrop-filter: blur(5.75256333rem);
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='4' height='4' viewBox='0 0 4 4'%3E%3Cpath fill='%234065b0' fill-opacity='0.4' d='M1 3h1v1H1V3zm2-2h1v1H3V1z'%3E%3C/path%3E%3C/svg%3E");
    background-color: #000614;
    border: none;
    box-shadow: 1rem 1rem 4.912423rem rgba(3, 2, 3, 0.1), -1rem 1rem 4.912423rem rgba(9, 2, 6, 0.1);
    cursor: pointer;
    color: #f7f9fe;
    right: 17.5rem;
  }

  .card-setting {
  }
</style>