<script setup lang="ts">
import { ref } from "vue"
import { defineStore } from "pinia"
import ShowCharacter from "../players/ShowCharacter.vue"
</script>

<template>
  <section>
    <article>
      <ShowCharacter />
    </article>
  </section>
</template>

<style scoped module="styles" lang="scss"></style>
