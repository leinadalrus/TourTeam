<script lang="ts">
import type DivisionCommander from "../fleet/DivisionCommander.vue"
import { defineComponent, defineProps } from 'vue'

type CommandInfo = {
  divisionCommander: typeof DivisionCommander
}

interface CommandData {
  bound: boolean
  post: CommandInfo | null
}

defineProps({
  commander: String,
  staff: String,
  bound: Boolean
})

export default defineComponent({
  data(): CommandData {
    return {
      bound: false,
      post: null
    }
  },
  methods: {
    fetchData(): void {
      this.bound = true
      this.post = null

      fetch("commander")
        .then(reader => reader.json())
        .then(embed => {
          this.bound = false
          this.post = embed as CommandInfo
        })
    }
  },
  watch: {
    "$route" : "fetchData"
  }
})
</script>

<template>
  <article>
    <div v-for="members in post" :accesskey="members.divisionCommander.uuid">
      <i>{{ members.divisionCommander.uuid }}</i>
      <h1>{{ members.divisionCommander.company }}</h1>
      <h2>{{ members.divisionCommander.division }}</h2>
      <span>{{ members.divisionCommander.lastName }}</span>
      <address>{{ members.divisionCommander.firstName }}</address>
    </div>
  </article>
</template>

<style scoped module="styles" lang="scss"></style>